using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Models
{
    public class AddressTranslation : BaseTranslationEntity
    {
        public long AddressId { get; set; }
        public string Street { get; set; }

        public Address Address { get; set; }
    }
}
