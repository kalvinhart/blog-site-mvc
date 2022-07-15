namespace BlogSite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public List<Article>? Articles { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}