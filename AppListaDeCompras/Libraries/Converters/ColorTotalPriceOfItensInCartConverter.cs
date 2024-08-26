using System.Drawing;
using System.Globalization;

namespace AppListaDeCompras.Libraries.Converters
{
    public class ColorTotalPriceOfItensInCartConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            bool hasCaught = (bool)value;

            if (hasCaught)
            {
                if (App.Current.PlatformAppTheme == AppTheme.Light)
                {
                    return Colors.Black;
                }
                else if (App.Current.PlatformAppTheme == AppTheme.Dark)
                {
                    return Colors.White;
                }
            }            
                    return Colors.DarkGray;
            //return (hasCaught) ? Colors.Black : Colors.LightGray;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
