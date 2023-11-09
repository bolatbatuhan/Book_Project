using Book_Project.Models;

namespace Book_Project.Business;

public interface IAuthorService
{
    void GetList();
    void Add(Author author);

    void Delete(int id);

    void GetById(int id);
}
