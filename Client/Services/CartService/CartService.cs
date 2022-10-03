using Blazored.LocalStorage;
using Hoalu.Shared;

namespace Hoalu.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;
        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, HttpClient http)
        {
            _localStorage = localStorage;
            _http = http;
        }
        public async Task AddToCart(CartItem cartItem)
        {
            var cart = await GetCart();
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            var sameItem = cart.Find(i => i.ProductId == cartItem.ProductId);
            if(sameItem == null)
            {
                cart.Add(cartItem);
            }else
            {
                sameItem.Quantity += cartItem.Quantity;
            }

            await SetCart(cart); 
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await GetCart();

            return cart;
        }

        public async Task<List<CartProductResponse>> GetCartProducts()
        {
            var cartItems = await GetCart();
            var response = await _http.PostAsJsonAsync("api/cart/products", cartItems);
            var cartProducts = await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();
            return cartProducts.Data;

        }

        public async Task RemoveProductFromCart(int productId)
        {
            var cart = await GetCart();
            if (cart == null)
            {
                return;
            }
            
            var cartItem = cart.Find(i => i.ProductId == productId);
            if(cartItem != null)
            {
                cart.Remove(cartItem);
                await _localStorage.SetItemAsync("cart", cart);
                OnChange.Invoke();
            }
        }

        public async Task UpdateQuantity(CartProductResponse product)
        {
            var cart = await GetCart();
            if (cart == null)
            {
                return;
            }
            var cartItem = cart.Find(i => i.ProductId == product.ProductId);
            if (cartItem != null)
            {
                cartItem.Quantity = product.Quantity;
                await SetCart(cart);
            }
        }

        private async Task<List<CartItem>> GetCart()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

            return cart;
        }
        private async Task SetCart(List<CartItem> cart)
        {
            await _localStorage.SetItemAsync("cart", cart);
        }

    }
}
