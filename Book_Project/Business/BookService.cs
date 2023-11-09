using Book_Project.Data;
using Book_Project.Exceptions;
using Book_Project.Models;

namespace Book_Project.Business;
public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }


    // Ekleme isi yaparken kitap basligi minimum 2 karakterli olmalidir.
    // Price ve Stock Propertyleri - deger alamaz!
    public void Add(Book book)
    {
       try
        {
            AddRules(book);
            _bookRepository.Add(book);
            GetList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int Id)
    {
        try
        {
            _bookRepository.Delete(Id);
            GetList();
        }catch(BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int Id)
    {
        try
        {
            Book? book = _bookRepository.GetById(Id);
            Console.WriteLine(book);

        }catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }
    private void AddRules(Book book)
    {
        if (book.Title.Length < 2)
        {
            throw new BookTitleException(book.Title);
        }
        if (book.Price < 0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }
    }
}
