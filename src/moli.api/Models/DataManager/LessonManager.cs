using System.Collections.Generic;
using moli.api.Models.Repository;
using System.Linq;

namespace moli.api.Models.DataManager
{
  public class LessonManager : IDataRepository<Lesson>
  {
    readonly MoliContext _lessonContext;

    public LessonManager(MoliContext context)
    {
      _lessonContext = context;
    }

    public void Add(Lesson entity)
    {
      _lessonContext.Lessons.Add(entity);
      _lessonContext.SaveChanges();
    }

    public void Delete(long id)
    {
      _lessonContext.Lessons.Remove(Get(id));
      _lessonContext.SaveChanges();
    }

    public Lesson Get(long id)
    {
      return _lessonContext.Lessons.FirstOrDefault(e => e.Id == id);
    }

    public IEnumerable<Lesson> GetAll()
    {
      return _lessonContext.Lessons.ToList();
    }

    public void Update(Lesson existingEntity, Lesson updatedEntity)
    {
      existingEntity.Name = updatedEntity.Name;

      _lessonContext.SaveChanges();
    }
  }
}
