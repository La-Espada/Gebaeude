using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Gebäude
{
    class QuadratMeterConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double quadratmeter = 0;

            quadratmeter = ((double)values[0]) * ((double)values[1]) * (double)((int)values[2]+1);
            
            return $"{Math.Round(quadratmeter,2)} m²";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
