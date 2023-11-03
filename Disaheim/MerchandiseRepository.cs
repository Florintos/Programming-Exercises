using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises { get; set; } = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise locatedMerchandise = null;

            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                {
                    locatedMerchandise = merchandise;
                    break;
                }
            }

            return locatedMerchandise;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();

            double totalValue = 0;

            foreach (Merchandise merchandise in merchandises)
            {
                double value = 0;

                if (merchandise is Book book)
                {
                    value = book.Price;
                }
                else if (merchandise is Amulet amulet)
                {
                    if (amulet.Quality == Enum.Level.low)
                    {
                        value = utility.LowQualityValue;
                    }
                    else if (amulet.Quality == Enum.Level.medium)
                    {
                        value = utility.MediumQualityValue;
                    }
                    else if (amulet.Quality == Enum.Level.high)
                    {
                        value = utility.HighQualityValue;
                    }
                }

                totalValue += value;
            }

            return totalValue;
        }
    }
}
