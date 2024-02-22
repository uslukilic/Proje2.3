using Proje2._3.EntitiyLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje2._3.Busines
{
    public interface ICategoryService : IGenericService<Catagory>
    {
    }
    public interface ICourseService : IGenericService<course>
    {
    }
    public interface IGenericService<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
        List<T> GetWhere(Expression<Func<T, bool>> expression);
    }
    public interface IInstructorService : IGenericService<Instructor>
    {
    }
    public interface IUserService : IGenericService<User>
    {
    }
}
