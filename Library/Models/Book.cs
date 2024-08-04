namespace OnlineLibrary.Models
{
    public class Book
    {
        private string Title;
        private string Author;
        private int PublicationYear;
        public Book(string title, string author, int publicationYear)
        {
            this.Title = title;
            this.Author = author;
            this.PublicationYear = publicationYear;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }
        public int GetPublicationYear()
        {
            return PublicationYear;
        }
    }
}
