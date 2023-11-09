
using Book_Project.Business;
using Book_Project.Exceptions;
using Book_Project.Data;
using Book_Project.Models;

IBookService bookService = new BookService(new BookRepository());

bookService.GetList();


Book book = new Book()
{
    Id = 11,
    Description = "x",
    Price = 214,
    Stock = 1232,
    Title = "zaa",
    AuthorId = 1,
    Isbn = "21312321",
    
    
};

Console.WriteLine("Kayit ekleme");
bookService.Add(book);

IAuthorService authorService = new AuthorService(new AuthorRepository());
authorService.GetList();
Author author = new Author()
{
    Id = 4,
    Name = "asd",
};

Console.WriteLine("Yazar ekleme");
authorService.Add(author);

