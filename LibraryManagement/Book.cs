namespace LibraryManagement
{
    public class Book
    {
        public Book(string title, string author, string iSBN)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = iSBN;
            this.Availability = true;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }
    }
}
