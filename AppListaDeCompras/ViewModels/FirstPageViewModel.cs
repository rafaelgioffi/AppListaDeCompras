using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
