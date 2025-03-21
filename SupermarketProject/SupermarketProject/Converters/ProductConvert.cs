﻿using SupermarketProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SupermarketProject.Converters
{
    public class ProductConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values == null || values.Length < 4 || values[0] == null || values[1] == null || values[2] == null || values[3] == null)
            {
                return null;
            }

            var name = values[0].ToString();
            var barcode = values[1].ToString();
            bool isCategoryID = int.TryParse(values[2]?.ToString(), out var categoryID);
            bool isProducerID = int.TryParse(values[3]?.ToString(), out var producerID);

            if (!isCategoryID || !isProducerID)
            {
                return null;
            }

            return new Product()
            {
                Name = name,
                Barcode = barcode,
                CategoryID = categoryID,
                ProducerID = producerID
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
