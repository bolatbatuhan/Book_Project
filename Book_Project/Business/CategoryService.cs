using Book_Project.Data;

namespace Book_Project.Business;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void GetList()
    {
        _categoryRepository
            .GetAll()
            .ForEach(c => Console.WriteLine(c));
    }
}
