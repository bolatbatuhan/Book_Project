using Book_Project.Models;

namespace Book_Project.Data;

public interface ICategoryRepository : IEntityRepository<Category,string>
{
}
