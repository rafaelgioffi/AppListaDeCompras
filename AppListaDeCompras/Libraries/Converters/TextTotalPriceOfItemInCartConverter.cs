using AppListaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDeCompras.Libraries.Converters
{
    public class TextTotalPriceOfItemInCartConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var product = values[0] as Product;            

            if (product == null)
            {                
                return 0.ToString("C");
            }

            if (product.HasCaught)
            {
                Console.WriteLine((product.Quantity * product.Price).ToString("C"));
                return (product.Quantity * product.Price).ToString("C");
            }
            else
            {
                if (product.Price > 0)
                {
                    Console.WriteLine($"{product.Price.ToString("C")} {product.QuantityUnityMeasure}");
                    return $"{product.Price.ToString("C")} {product.QuantityUnityMeasure}";
                }
            }
            return 0.ToString("C");
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
