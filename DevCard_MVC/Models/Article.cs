namespace DevCard_MVC.Models
{
    public class Article
    {
        public Article(long id , string tiltle, string description, string image)
        {
            Id = id;
            Tiltle = tiltle;
            Description = description;
            Image = image;
        }
        public long Id { get; set; }
        public string Tiltle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
