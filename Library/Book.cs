class Book {
    private string title;
    private string author;
    private int publicationYear;
    public Book(string title,string author,int publicationYear){
        this.title=title;
        this.author=author;
        this.publicationYear=publicationYear;
    }

    public string GetTitle() {
        return title;
    }

    public string GetAuthor() {
        return author;
    }
    public int GetPublicationYear(){
        return publicationYear;
    }
}