using System.Collections.Generic;
using moli.api.Models.Repository;
using System.Linq;

namespace moli.api.Models.DataManager
{
  public class TestManager : IDataRepository<Test>
  {
    readonly MoliContext _testContext;

    public TestManager(MoliContext context)
    {
      _testContext = context;
    }

    public void Add(Test entity)
    {
      _testContext.Tests.Add(entity);
      _testContext.SaveChanges();
    }

    public void Delete(long id)
    {
      _testContext.Tests.Remove(Get(id));
      _testContext.SaveChanges();
    }

    public Test Get(long id)
    {
      return _testContext.Tests.FirstOrDefault(e => e.Id == id);
    }

    public IEnumerable<Test> GetAll()
    {
      return _testContext.Tests.ToList();
    }

    public void Update(Test existingEntity, Test updatedEntity)
    {
      existingEntity.Name = updatedEntity.Name;

      _testContext.SaveChanges();
    }
  }
}
