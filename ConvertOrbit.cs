using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SolarSystem
{
    public class ConvertOrbit : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double orbit = (double)value;
            double factor = System.Convert.ToDouble(parameter, culture.NumberFormat);

            return Math.Pow(orbit / 40, 0.4) * 700 * factor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Этот метод не должен быть вызван");
        }
    }
}
