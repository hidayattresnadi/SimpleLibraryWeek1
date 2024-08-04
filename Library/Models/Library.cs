namespace OnlineLibrary.Models
{
    public class Library
    {
        private List<Book> BooksCollection = new List<Book>();
        public string AddBook(Book book)
        {
            bool isBookAvailable = CheckAvailableBook(book);
            if (isBookAvailable)
            {
                return "Book is already added. You cannot add the same book.";
            }
            BooksCollection.Add(book);
            return $"Book '{book.GetTitle()}' is added successfully."; ;
        }

        public bool CheckAvailableBook(Book book)
        {
            bool isAvailable = false;
            Book checkBook = BooksCollection.FirstOrDefault(item => item.GetTitle() == book.GetTitle());
            if (checkBook != null)
            {
                isAvailable = true;
            }
            return isAvailable;
        }
        public List<Book> DisplayBooks()
        {
            foreach (var item in BooksCollection)
            {
                Console.WriteLine("=============");
                Console.WriteLine($"Book title is '{item.GetTitle()}'.");
                Console.WriteLine($"Book author is '{item.GetAuthor()}'.");
                Console.WriteLine($"Book publication year is {item.GetPublicationYear()}.");
            }
            return BooksCollection;
        }
        public string RemoveBook(string title)
        {
            int indexBook = BooksCollection.FindIndex(item => item.GetTitle() == title);
            if (indexBook == -1)
            {
                return "Book is not found";
            }
            BooksCollection.RemoveAt(indexBook);
            return "Book has been removed.";
        }
    }
}