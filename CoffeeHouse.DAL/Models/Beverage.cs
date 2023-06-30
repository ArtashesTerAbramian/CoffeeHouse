namespace CoffeeHouse.DAL.Models;

public class Beverage : BaseEntity
{
    public string Name { get; set; }
    public CoffeeType? CoffeeType { get; set; }
}
