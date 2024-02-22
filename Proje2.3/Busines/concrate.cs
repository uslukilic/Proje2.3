using Proje2._3.EntitiyLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje2._3.Busines
{
    public class CategoryManager : ICategoryService
    {
        public readonly ICatagoryDal _categoryDal;

        public CategoryManager(ICatagoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Catagory entity)
        {
            throw new NotImplementedException();
        }

        public List<Catagory> GetAll()
        {
            throw new NotImplementedException();
        }

        public Catagory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Catagory> GetWhere(Expression<Func<Catagory, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Catagory entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Catagory entity)
        {
            throw new NotImplementedException();
        }
    }
    public class courseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public courseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Delete(course entity)
        {
            throw new NotImplementedException();
        }

        public List<course> GetAll()
        {
            throw new NotImplementedException();
        }

        public course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<course> GetWhere(Expression<Func<course, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(course entity)
        {
            throw new NotImplementedException();
        }

        public void Update(course entity)
        {
            throw new NotImplementedException();
        }
    }
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Delete(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetWhere(Expression<Func<Instructor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetWhere(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }


}
