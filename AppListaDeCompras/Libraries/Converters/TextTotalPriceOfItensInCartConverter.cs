using AppListaDeCompras.Models;
using System.Globalization;

namespace AppListaDeCompras.Libraries.Converters
{
    public class TextTotalPriceOfItensInCartConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            ListToBuy listToBuy = value as ListToBuy;

            decimal totalPrice = 0;

            if (listToBuy is null)
            {
                return totalPrice.ToString("C");
            }

            if (listToBuy.Products.Count == 0)
            {
                return totalPrice.ToString("C");
            }

            foreach (var product in listToBuy.Products)
            {
                //TODO - Impacto: Unidade de medidas no preço total...
                if (product.HasCaught)
                {
                    totalPrice += product.Price * product.Quantity;
                }
            }

            return totalPrice.ToString("C");
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
