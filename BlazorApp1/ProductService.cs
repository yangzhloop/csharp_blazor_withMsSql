using System.Net.Http.Json;

    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("api/products");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching products: {ex.Message}");
                return Enumerable.Empty<Product>();
            }
        }
    }

