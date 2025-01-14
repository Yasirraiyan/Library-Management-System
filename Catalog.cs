using System.Collections.Generic;

public class Catalog
{
    public int CatalogID { get; set; }
    public List<Book> Books { get; set; }

    public Catalog()
    {
        Books = new List<Book>();
    }

    public void SearchBookByTitle(string title)
    {
        foreach (var book in Books)
        {
            if (book.Title == title)
            {
                Console.WriteLine($"Book found: {book.Title}");
            }
        }
    }
}
