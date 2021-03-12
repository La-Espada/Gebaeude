using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Gebäude
{
    class XCoordinateConverter : IMultiValueConverter
    {
      

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double temp = 0;
            if (values[0] != null)
            {
                temp = (double)values[1] - (double)values[0]; 
            }
            return temp;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
