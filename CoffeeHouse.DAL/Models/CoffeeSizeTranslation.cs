namespace CoffeeHouse.DAL.Models;

public class CoffeeSizeTranslation : BaseTranslationEntity
{
    public long CoffeeSizeId { get; set; }
    public string Size { get; set; }

    public CoffeeSize CoffeeSize { get; set; }
}
