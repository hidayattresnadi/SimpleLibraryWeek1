// See https://aka.ms/new-console-template for more information

class Program {
    static void Main() {
        Library library= new Library();
        Book komik = new Book ("Naruto","Masashi Kishimoto",2020);
        Book novel = new Book ("Fate Strange Fake","Nasu",2021);
        Book sejarah = new Book("King Arthur","dayat",2022);
        Book sejarah1 = new Book("King Arthur","dayat",2022);
        Book sejarah2 = new Book("King Arthur","dayat",2021);
        library.AddBook(komik);
        library.AddBook(novel);
        library.AddBook(sejarah);
        Console.WriteLine("wkwkwkw");
        Console.WriteLine(library.AddBook(sejarah1));
        Console.WriteLine(library.AddBook(sejarah2));
        var dataBooks = library.DisplayBooks();
        foreach (var item in dataBooks)
        {
            Console.WriteLine(item.GetTitle());
            Console.WriteLine(item.GetAuthor());
            Console.WriteLine(item.GetPublicationYear());
        }
        library.RemoveBook(komik);
        foreach (var item in dataBooks)
        {
            Console.WriteLine("=======");
            Console.WriteLine(item.GetTitle());
            Console.WriteLine(item.GetType());
            Console.WriteLine(item.GetPublicationYear());
        }
    }
}
