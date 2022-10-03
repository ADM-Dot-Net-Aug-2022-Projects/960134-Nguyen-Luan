namespace Hoalu.Client.Services.ProductService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCagetories();
    }
}
