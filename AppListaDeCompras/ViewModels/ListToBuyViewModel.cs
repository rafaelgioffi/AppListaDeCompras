using AppListaDeCompras.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AppListaDeCompras.ViewModels
{
    public partial class ListToBuyViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ListToBuy> _listToBuy;
        public ListToBuyViewModel()
        {
            ListToBuy = new ObservableCollection<ListToBuy>() {
        new ListToBuy() {
            Id = 1,
        Name = "Minha Lista 1",
        Users = new List<User>()
        {
            new User {
                Name = "Rafael",
                Email="rafaegioffi@gmail.com"
            },
            new User {
                Name = "Bruna",
                Email="brunarpereira@hotmail.com"
            }
            },
            Products = new List<Product>()
            {
                new Product { Name = "Arroz Tipo 1 Tio Lautério 5Kg", Quantity = 1, Price = 32.98m, HasCaught = true },
                new Product { Name = "Filé de peito de frango Sadia 1Kg", Quantity = 3, Price = 16.99m, HasCaught = true },
                new Product { Name = "Alho a granel", Quantity = 1, Price = 8.49m },
        },
        CreateAt = DateTime.Now,
        },

        new ListToBuy()
        {
            Id = 2,
            Name = "Minha Lista 2",
        Users = new List<User>()
        {
            new User {
                Name = "Rafael",
                Email="rafaegioffi@gmail.com"
            },
        },
        Products = new List<Product>()
            {
                new Product { Name = "Banana", Quantity = 1, Price = 5.49m, HasCaught = true },
                new Product { Name = "Biscoito de Maisena Marilan c/ 3", Quantity = 3, Price = 6.49m, HasCaught = true },
        },
        CreateAt = DateTime.Now.AddDays(-7),

        }

    };
        }
    }
}