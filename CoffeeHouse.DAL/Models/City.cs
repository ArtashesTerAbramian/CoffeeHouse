using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Models
{
    public class City : BaseEntity
    {
        public City()
        {
            Translations = new HashSet<CityTranslation>();
        }

        public long ProvinceId { get; set; }

        public Province Province { get; set; }

        public ICollection<CityTranslation> Translations { get; set; }
    }
}
