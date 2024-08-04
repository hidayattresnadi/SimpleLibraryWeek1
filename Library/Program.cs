using OnlineLibrary.Models;
class Program
{
    static void Main()
    {
        Library library = new Library();
        Book komik = new Book("Naruto", "Masashi Kishimoto", 2020);
        Book novel = new Book("Fate Strange Fake", "Nasu", 2021);
        Book sejarah = new Book("King Arthur", "dayat", 2022);
        Book sejarah1 = new Book("King Arthur", "dayat", 2022);
        Console.WriteLine(library.AddBook(komik));
        Console.WriteLine(library.AddBook(novel));
        Console.WriteLine(library.AddBook(sejarah));
        // Trying to add dupplicate Book
        Console.WriteLine(library.AddBook(sejarah1));
        library.DisplayBooks();
        // Remove One book
        Console.WriteLine(library.RemoveBook("King Arthur"));
        // trying to remove unavailable book at library
        Console.WriteLine(library.RemoveBook("Titanic"));
        Console.WriteLine("Book after removed");
        library.DisplayBooks();
    }
}