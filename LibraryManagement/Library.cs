namespace LibraryManagement
{
    public class Library
{
    private List<Book> books = new List<Book>();

   
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Added '{book.Title}' to the library.");
    }

    // Search for a book 
    public Book SearchBook(string title)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Title.ToLower().Contains(title.ToLower()))
            {
                return books[i];
            }
        }
        return null;
    }

    // Borrow a book
    public void BorrowBook(string title)
    {
        Book book = SearchBook(title);
        if (book != null && book.Availability)
        {
            book.Availability = false;
            Console.WriteLine($"You have borrowed '{book.Title}'.");
        }
        else
        {
            if (book == null)
            {
                Console.WriteLine($"The book '{title}' is not in the library.");
            }
            else
            {
                Console.WriteLine($"The book '{book.Title}' is currently borrowed.");
            }
        }
    }

    // Return a book
    public void ReturnBook(string title)
    {
        Book book = SearchBook(title);
        if (book != null && !book.Availability)
        {
            book.Availability = true;
            Console.WriteLine($"You have returned '{book.Title}'.");
        }
        else
        {
            if (book == null)
            {
                Console.WriteLine($"The book '{title}' is not in the library.");
            }
            else
            {
                Console.WriteLine($"The book '{book.Title}' is not borrowed.");
            }
        }
    }
}
}
