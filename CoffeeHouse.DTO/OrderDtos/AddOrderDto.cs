using CoffeeHouse.DAL.Enums;
using CoffeeHouse.DAL.Models;
using System.Collections.ObjectModel;

namespace CoffeeHouse.DTO.OrderDtos;

public class AddOrderDto
{
    public long UserId { get; set; }
    public long AddressId { get; set; }
    public ObservableCollection<Coffee> Coffees { get; set; }
    public string? Instruction { get; set; }
    public OrderTimingType? OrderTimingType { get; set; }
    public DateTime? BeReadyOn { get; set; }
}
