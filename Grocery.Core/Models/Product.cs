using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        public int stock;
        public DateOnly ShelfLife { get; set; }
        
        [ObservableProperty]
        public double price;
        public Product(int id, string name, double price, int stock) : this(id, name, stock, default(DateOnly), price) { }

        public Product(int id, string name, int stock, DateOnly shelfLife, double Price) : base(id, name)
        {
            Stock = stock;
            ShelfLife = shelfLife;
            Price = price;
        }
        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad";
        }
    }
}
