using Book_Project.Consts;

namespace Book_Project.Exceptions;

public class BookTitleException : Exception
{
    public BookTitleException(string title) : base(Messages.BookTitleExceptionMessage(title))
    {

    }
}
