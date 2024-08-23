using CommunityToolkit.Mvvm.ComponentModel;

namespace AppListaDeCompras.Models
{
    public partial class Product : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string QuantityUnityMeasure { get; set; }
        public decimal Price { get; set; }

        [ObservableProperty]
        private bool hasCaught = false;
    }
}
