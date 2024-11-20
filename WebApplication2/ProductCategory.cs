using ShopOnlineApi.Models;

namespace Demo.Api
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property for related Products
        public ICollection<Product> Products { get; set; }
    }
}
