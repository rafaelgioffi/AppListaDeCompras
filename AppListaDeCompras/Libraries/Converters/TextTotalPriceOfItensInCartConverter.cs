using AppListaDeCompras.Models;
using System.Globalization;

namespace AppListaDeCompras.Libraries.Converters
{
    public class TextTotalPriceOfItensInCartConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            List<Product>? listOfProducts = value as List<Product>;

            decimal totalPrice = 0;

            if (listOfProducts is null)
            {
                return totalPrice.ToString("C");
            }

            if (listOfProducts.Count == 0)
            {
                return totalPrice.ToString("C");
            }


            foreach (var product in listOfProducts)
            {                
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
