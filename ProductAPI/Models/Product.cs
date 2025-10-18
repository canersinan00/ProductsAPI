namespace ProductsAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;

        public decimal Price{ get; set; }

        public bool IsActive { get; set; }
    }
}
