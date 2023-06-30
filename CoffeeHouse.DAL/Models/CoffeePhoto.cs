namespace CoffeeHouse.DAL.Models;

public class CoffeePhoto : BasePhotoEntity
{
    public long CoffeeId { get; set; }

    public Coffee Coffee { get; set; }
}
