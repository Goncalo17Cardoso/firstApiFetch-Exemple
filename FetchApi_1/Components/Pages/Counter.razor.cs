namespace FetchApi_1.Components.Pages
{
    public partial class Counter
    {
        public Product produto;

        public HttpClient httpclient = new HttpClient();

        public async Task FetchData()
        {
            produto = await httpclient.GetFromJsonAsync<Product>("https://localhost:7015/api/Products/1");
        }

        public class Product
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Brand { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }

            public string Description { get; set; }

            public DateTime CreatedAt { get; set; }
        }
    }
}
