namespace bai3.Models
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        public category category { get; set; } = null!;
    }
}
