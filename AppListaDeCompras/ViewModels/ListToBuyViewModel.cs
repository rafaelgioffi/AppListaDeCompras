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
                new Product { },
                new Product { },
                new Product { },
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
        CreateAt = DateTime.Now.AddDays(-7),

        }

    };
        }
    }
}