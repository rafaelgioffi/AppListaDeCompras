﻿using AppListaDeCompras.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppListaDeCompras.ViewModels
{
    [QueryProperty(nameof(ListToBuy), "ListToBuy")]
    public partial class ListOfItensPageViewModel : ObservableObject
    {
        private ListToBuy? _listToBuy;

        public ListToBuy? ListToBuy
        {
            get => _listToBuy;
            set => SetProperty(ref _listToBuy, value);
        }

        [RelayCommand]
        private void UpdateListToBuy()
        {                       
            OnPropertyChanged(nameof(ListToBuy));
        }
    }
}
