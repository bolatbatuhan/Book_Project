using Book_Project.Models;

namespace Book_Project.Business;

public interface IBookService
{
    void GetList();
    void Add(Book book);
    void GetById(int Id);
    void Delete(int Id);
}
