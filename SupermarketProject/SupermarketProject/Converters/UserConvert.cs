using SupermarketProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SupermarketProject.Converters
{
    public class UserConvert:IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null&& values[2]!=null)
            {
                return new User()
                {
                    Name = values[0].ToString(),
                    Password = values[1].ToString(),
                    Type = values[2].ToString(),
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
