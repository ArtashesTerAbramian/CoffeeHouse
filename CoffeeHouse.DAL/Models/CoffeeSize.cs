using CoffeeHouse.DAL.Enums;

namespace CoffeeHouse.DAL.Models;

public class CoffeeSize : BaseEntity
{
    public CoffeeSize()
    {
        Translations = new HashSet<CoffeeSizeTranslation>();
    }
    public CoffeeSizeEnum SizeEnum { get; set; }

    public ICollection<CoffeeSizeTranslation> Translations { get; set; }

}
