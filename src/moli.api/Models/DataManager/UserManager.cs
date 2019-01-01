using System.Collections.Generic;
using moli.api.Models.Repository;
using System.Linq;

namespace moli.api.Models.DataManager
{
  public class UserManager : IDataRepository<User>
  {
    readonly MoliContext _userContext;

    public UserManager(MoliContext context)
    {
      _userContext = context;
    }

    public void Add(User entity)
    {
      _userContext.Users.Add(entity);
      _userContext.SaveChanges();
    }

    public void Delete(long id)
    {
      _userContext.Users.Remove(Get(id));
      _userContext.SaveChanges();
    }

    public User Get(long id)
    {
      return _userContext.Users.FirstOrDefault(e => e.Id == id);
    }

    public IEnumerable<User> GetAll()
    {
      return _userContext.Users.ToList();
    }

    public void Update(User existingEntity, User updatedEntity)
    {
      existingEntity.Name = updatedEntity.Name;
      existingEntity.Email = updatedEntity.Email;
      
      _userContext.SaveChanges();
    }
  }
}
