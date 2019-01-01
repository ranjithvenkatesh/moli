using System.Collections.Generic;

namespace moli.api.Models.Repository
{
  public interface IDataRepository<TEntity>
  {
    IEnumerable<TEntity> GetAll();
    TEntity Get(long id);
    void Add(TEntity entity);
    void Update(TEntity existingEntity, TEntity updatedEntity);
    void Delete(long id);
  }
}
