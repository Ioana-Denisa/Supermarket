using SupermarketProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SupermarketProject.Converters
{
    public class ProducerConvert:IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values == null || values.Length < 2 || values[0] == null || values[1] == null)
            {
                return null;
            }

            var name = values[0].ToString();
            var country = values[1].ToString();
         
            return new Producer()
            {
                Name = name,
                Country = country,
             
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
