using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Models
{
    public class CityTranslation : BaseTranslationEntity
    {
        public long CityId { get; set; }
        public string Name { get; set; }

        public City City { get; set; }
    }
}
