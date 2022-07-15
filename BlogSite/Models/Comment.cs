namespace BlogSite.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; } = null!;
        public int Likes { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int ArticleId { get; set; }
        public Article Article { get; set; } = null!;
    }
}