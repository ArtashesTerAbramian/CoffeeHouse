namespace CoffeeHouse.DAL.Models;

public class Coffee : BaseWithMedia<CoffeePhoto>
{
    public Coffee()
    {
        Translations = new HashSet<CoffeeTranslation>();
    }
    public ICollection<CoffeeTranslation> Translations { get; set; }
}
