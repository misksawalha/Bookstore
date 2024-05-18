namespace Bookstore.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; } = null!;
        public DateTime CreatedAt { set; get; } = DateTime.Now;

        public DateTime UpdatedAt { set; get; } = DateTime.Now;
    }
}
