using Book_Project.Consts;

namespace Book_Project.Exceptions;

public class BookNotFoundWithIsbn : Exception
{
    public  BookNotFoundWithIsbn(string isbn) : base(Messages.BookNotFoundWithIsbnMessage(isbn)) { }
}
