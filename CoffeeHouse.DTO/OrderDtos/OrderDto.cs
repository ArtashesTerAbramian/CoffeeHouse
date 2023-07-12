using CoffeeHouse.DAL.Enums;
using CoffeeHouse.DAL.Models;
using System.Collections.ObjectModel;

namespace CoffeeHouse.DTO.OrderDtos;

public class OrderDto : BaseEntity
{
    public long UserId { get; set; }
    public long AddressId { get; set; }
    public string Instruction { get; set; }
    public OrderTimingType? TimingType { get; set; }
    public DateTime? BeReadyOn { get; set; }
    public bool IsReady { get; set; }
    public decimal TotalPrice{ get; set; }

    public ObservableCollection<Coffee> Coffees { get; set; }
}
