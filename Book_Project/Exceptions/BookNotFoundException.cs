namespace Book_Project.Exceptions;
public class BookNotFoundException : Exception
{
    public BookNotFoundException(int id) : base($"ID : {id}'ye ait kitap bulunamadi.")
    {
    }
}
