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

    public void Delete(User user)
    {
      _userContext.Users.Remove(user);
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

    public void Update(User user, User entity)
    {
      user.Name = entity.Name;
      user.Email = entity.Email;
      
      _userContext.SaveChanges();
    }
  }
}
