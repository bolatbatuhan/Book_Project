using Book_Project.Data;
using Book_Project.Exceptions;
using Book_Project.Models;

namespace Book_Project.Business;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public void Add(Author author)
    {
        try
        {
            Rules(author);
            _authorRepository.Add(author);
            
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _authorRepository.Delete(id);
            GetList();
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Author? author = _authorRepository.GetById(id);
            Console.WriteLine(author);
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void GetList()
    {
        _authorRepository
            .GetAll()
            .ForEach(a => Console.WriteLine(a));
    }
    private void Rules(Author author)
    {
        if(author.Name.Length < 2)
        {
            throw new AuthorNameException(author.Name);
        }
    }
}
