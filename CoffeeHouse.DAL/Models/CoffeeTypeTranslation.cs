using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Models
{
    public class CoffeeTypeTranslation : BaseTranslationEntity
    {
        public long CoffeeTypeId { get; set; }
        public string Name { get; set; }

        public CoffeeType CoffeeType { get; set; }
    }
}
