namespace CoffeeHouse.DAL.Models;

public class Coffee : BaseWithMedia<CoffeePhoto>
{
    public Coffee()
    {
        Translations = new HashSet<CoffeeTranslation>();
    }
    public long? CoffeeTypeId { get; set; }

    public ICollection<CoffeeTranslation> Translations { get; set; }
    public CoffeeType CoffeeType { get; set; }
}
