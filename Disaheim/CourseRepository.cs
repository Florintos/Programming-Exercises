using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class CourseRepository
    {
        public List<Course> courses { get; set; } = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string Name)
        {
            Course locatedCourse = null;

            foreach (Course c in courses)
            {
                locatedCourse = c;
                if (c.Name == Name)
                break;
            }

            return locatedCourse;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (Course course in courses)
            {
                double value = 0;

                int hoursStarted = course.DurationInMinutes / 60;
                bool anyminutes = course.DurationInMinutes % 60 != 0;
                value = anyminutes ? (hoursStarted + 1) * 875 : hoursStarted * 875;

                totalValue += value;
            }

            return totalValue;
        }
    }
}
