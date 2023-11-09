using Book_Project.Models;
using Book_Project.Exceptions;

namespace Book_Project.Data;

public class AuthorRepository : IAuthorRepository
{
    private readonly List<Author> _authors;

    public AuthorRepository()
    {
        _authors = new List<Author>()
        {
        new Author { Id = 1, Name = "Suzanne Collins" },
        new Author { Id = 2, Name = "Sait Faik Abasiyanik" },
        new Author { Id = 3, Name = "J. K. Rowling" },
        };
    }
    public void Add(Author author)
    {
        _authors.Add(author);
    }

    public void Delete(int id)
    {
        Author? author = _authors.Where(x => x.Id == id).SingleOrDefault();
        if(author is null)
        {
            throw new BookNotFoundException(id);
        }
        _authors.Remove(author);
    }

    public List<Author> GetAll()
    {
        return _authors;
    }

    public Author? GetById(int id)
    {
        Author? author = _authors.SingleOrDefault(x => x.Id == id);
        {
            if(author is null)
            {
                throw new BookNotFoundException(id);
            }

            return author;
        }
    }
}
