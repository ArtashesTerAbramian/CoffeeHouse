using CoffeeHouse.DAL.Enums;

namespace CoffeeHouse.DAL.Models;

public class CoffeeType : BaseEntity
{
    public CoffeeType()
    {
        Translations = new HashSet<CoffeeTypeTranslation>();
    }
    public ICollection<CoffeeTypeTranslation> Translations { get; set; }
}
