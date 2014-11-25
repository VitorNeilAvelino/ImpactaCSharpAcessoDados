using System;
using System.Windows.Data;

namespace CSharp2.Capitulo10.Wpf.Produtos.Converters
{
    public class MultiplicadorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                return (System.Convert.ToDecimal(values[0]) * System.Convert.ToDecimal(values[1])).ToString();
            }
            catch 
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }
}