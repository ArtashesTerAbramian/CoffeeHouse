using CoffeeHouse.DAL.Enums;

namespace CoffeeHouse.DAL.Models;

public class BeverageSize : BaseEntity
{
    public BeverageSize()
    {
        Translations = new HashSet<BeverageSizeTranslation>();
    }
    public BeverageSizeEnum SizeEnum { get; set; }

    public ICollection<BeverageSizeTranslation> Translations { get; set; }

}
