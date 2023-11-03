using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Disaheim
{
    public class Utility
    {
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;
        public double CourseHourValue = 875.0;

        public double GetValueOfCourse (Course course)
        {
            int hoursStarted = course.DurationInMinutes / 60;
            bool anyminutes = course.DurationInMinutes % 60 != 0;
            return anyminutes ? (hoursStarted + 1) * CourseHourValue : hoursStarted * CourseHourValue;
        }

        public double GetValueOfMerchandise(Merchandise merchandise)
        {  
            double valueOfMerchandise = 0;

            if (merchandise is Book book)
            {
               return book.Price;
            }
            else if (merchandise is Amulet amulet)
            {
                double value = 0;

                if (amulet.Quality == Enum.Level.low)
                {
                    value = LowQualityValue;
                }
                if (amulet.Quality == Enum.Level.medium)
                {
                    value = MediumQualityValue;
                }
                if (amulet.Quality == Enum.Level.high)
                {
                    value = HighQualityValue;
                }

                valueOfMerchandise += value;
            }

            return valueOfMerchandise;
        }

    }
}
