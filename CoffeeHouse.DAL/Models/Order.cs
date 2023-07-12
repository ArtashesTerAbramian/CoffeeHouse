using CoffeeHouse.DAL.Enums;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CoffeeHouse.DAL.Models;

public class Order : BaseEntity
{
    public Order()
    {
        Coffees = new ObservableCollection<Coffee>();
        Coffees.CollectionChanged += CoffeesCollectionChanged;
    }
    public long UserId { get; set; }
    public long AddressId { get; set; }
    public string Instruction { get; set; }
    public OrderTimingType? TimingType { get; set; }
    public DateTime? BeReadyOn { get; set; }
    public bool IsReady { get; set; } = false;
    public decimal TotalPrice
    {
        get { return _total; }
        private set { _total = value; }
    }
    private decimal _total;

    public ObservableCollection<Coffee> Coffees { get; set; }

    User User { get; set; }
    Address Address { get; set; }

    private void CoffeesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        CalculateTotalPrice();
    }

    private void CalculateTotalPrice()
    {
        _total = 0;

        foreach (var coffee in Coffees)
        {
            _total += coffee.Price;
        }
    }
}
