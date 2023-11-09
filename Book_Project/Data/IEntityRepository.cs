namespace Book_Project.Data;

public interface IEntityRepository<TEntity,TId>
{
    void Add(TEntity category);

    void Delete(TId id);

    List<TEntity> GetAll();

    TEntity? GetById(TId id);
}
