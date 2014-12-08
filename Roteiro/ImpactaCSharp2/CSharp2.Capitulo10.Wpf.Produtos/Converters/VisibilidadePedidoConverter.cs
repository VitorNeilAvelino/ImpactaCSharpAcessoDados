using System;
using System.Windows.Data;

namespace CSharp2.Capitulo10.Wpf.Produtos.Converters
{
    public class VisibilidadePedidoConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                var podeVisualizar = (System.Convert.ToInt32(values[0]) == 1) && System.Convert.ToBoolean(values[1]);

                return podeVisualizar ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
            }
            catch 
            {
                return System.Windows.Visibility.Visible;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }
}