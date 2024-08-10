using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDeCompras.ViewModels
{
    partial class FirstPageViewModel : ObservableObject
    {
        [RelayCommand]
        private void NavigateToAppShell()
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
