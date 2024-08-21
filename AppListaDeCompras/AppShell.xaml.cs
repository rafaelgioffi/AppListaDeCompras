using AppListaDeCompras.Views;

namespace AppListaDeCompras
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("ListToBuy/ListOfItens", typeof(ListOfItensPage)); //Registrar a rota da página de itens
        }
    }
}
