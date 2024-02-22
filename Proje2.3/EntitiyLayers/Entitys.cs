using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2._3.EntitiyLayers
{
    public class Catagory
    {

        public int CategoryId {  get; set; }
        public string Name { get; set; }
        public ICollection<course>courses { get; set; }
    }
    public class course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int InstructorId { get; set; }
        public Instructor ınstructor { get; set; }
        public Catagory category { get; set; }
        public ICollection<User> users { get; set; }
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public ICollection<course> Courses { get; set; }
    }


    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int CourseId { get; set; }
        public course Course { get; set; }
        public int Complated { get; set; }
    }

}
