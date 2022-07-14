namespace BlogSite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public List<Article> Articles { get; set; } = new List<Article> {};
        public List<Comment> Comments { get; set; } = new List<Comment> {};
    }
}