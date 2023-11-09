using Book_Project.Consts;

namespace Book_Project.Exceptions;

public class BookPriceAndStockException : Exception
{
    public BookPriceAndStockException(double price, int stock) : base(Messages.BookPriceAndStockExceptionMessage(price, stock))
    {
    }
}
