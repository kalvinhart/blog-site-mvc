namespace BlogSite.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string TextContent { get; set; } = null!;
        public List<Comment>? Comments { get; set; }
        public int Likes { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}