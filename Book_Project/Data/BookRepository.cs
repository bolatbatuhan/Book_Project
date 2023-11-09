using Book_Project.Exceptions;
using Book_Project.Models;

namespace Book_Project.Data;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _bookData;

    public BookRepository()
    {
        _bookData = new List<Book>()
        {
              new Book{Id=1,CategoryId="A",AuthorId =1,Description="Güzel bir kitap",Price=250,Stock=2500,Title="Sherlock Holmes"},
              new Book{Id=2,CategoryId="A",AuthorId =3,Description="Güzel bir kitap",Price=120,Stock=500,Title="Arsen Lüpen"},
              new Book{Id=3,CategoryId="B",AuthorId =3,Description="Çok değerli bir kitap",Price=300, Stock=5000, Title="Nutuk"},
              new Book{Id=4,CategoryId="B",AuthorId =1,Description="Güzel bir kitap",Price=152,Stock=1000,Title="Cengiz Hanin Hayati"},
              new Book{Id=5,CategoryId="B",AuthorId =2,Description="Güzel bir kitap",Price=1020,Stock=5000,Title="Atilla"},
              new Book{Id=6,CategoryId="B",AuthorId =4,Description="Çok değerli bir kitap",Price=3000, Stock=5000, Title="Sumerin Goksel Atalari"},
              new Book{Id=7,CategoryId="C",AuthorId =5,Description="Güzel bir kitap",Price=22,Stock=140,Title="Iyi Hissetmek"},
              new Book{Id=8,CategoryId="C",AuthorId =5,Description="Güzel bir kitap",Price=300,Stock=50,Title="Psikoloji"},
              new Book{Id=9,CategoryId="C",AuthorId =5,Description="Çok değerli bir kitap",Price=145, Stock=100, Title="Psikoloji 1"},
        };
    }

    public void Add(Book book)
    {
        _bookData.Add(book);
    }

    public void Delete(int id)
    {
        Book? book = _bookData.Where(x => x.Id == id).SingleOrDefault();

        if (book is null)
        {
            throw new BookNotFoundException(id);
        }
        _bookData.Remove(book);

    }

    public Book? GetById(int id)
    {
        Book? book = _bookData.SingleOrDefault(x => x.Id == id);

        if (book == null)
        {
            throw new BookNotFoundException(id);
        }
        return book;
    }

    public List<Book?> GetAll()
    {
        return _bookData;
    }

    public Book GetByIsbn(string isbn)
    {
        Book? book = _bookData.SingleOrDefault(x => x.Isbn == isbn);
        if (isbn == null)
        {
            throw new BookNotFoundWithIsbn(isbn);
        }
        return book;
    }
}
