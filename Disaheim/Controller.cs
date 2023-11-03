using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }
        public List<Course> Courses { get; set; }
        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();  
            Courses = new List<Course>();
        }

        public void AddToList(Book books)
        {
            Books.Add(books);
        }

        public void AddToList(Amulet amulets)
        {
            Amulets.Add(amulets);
        }

        public void AddToList(Course courses)
        {
            Courses.Add(courses);
        }


    }
}
