class Library {
    private List<Book> bookCollection;

    public Library() {
        this.bookCollection = new List<Book>();
    }

    public Library(List<Book> book) {
        this.bookCollection = book;
    }

    public string AddBook(Book book){
        bool isBookAvailable = CheckAvailableBook(book);
        if (isBookAvailable)
        {
            return "Buku sudah ada di koleksi, tidak bisa ditambahkan lagi";
        }    
        bookCollection.Add(book);
        return "Buku berhasil ditambahkan";
    }

    public bool CheckAvailableBook(Book book){
        bool isAvailable = false;
        foreach (Book item in bookCollection)
        {
            int countTrue = 0;
            if (book.GetTitle() == item.GetTitle()) {
                countTrue++;
            }
            if(book.GetAuthor() == item.GetAuthor()){
                countTrue++;
            }
            if (book.GetPublicationYear() == item.GetPublicationYear()){
                countTrue++;
            }
            
            if (countTrue == 3) {
            isAvailable = true;
            }
        }
        return isAvailable;
    }


    public List<Book> DisplayBooks(){
        return bookCollection;
    }

    public string RemoveBook(Book book){
        bookCollection.Remove(book);
        return "Buku telah dihilangkan";
    }
}