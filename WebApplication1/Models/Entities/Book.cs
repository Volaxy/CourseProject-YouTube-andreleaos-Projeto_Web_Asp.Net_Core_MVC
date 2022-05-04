namespace WebApplication1.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book() { }

        public Book(int id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }
    }
}
