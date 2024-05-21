using SupermarketProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SupermarketProject.Converters
{
    public class StockConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null && values[5] != null )
            {
                bool isProductID = int.TryParse(values[0].ToString(), out var productID);
                bool isQuantity = int.TryParse(values[1].ToString(), out var quantity);
                bool isSupplyDate = DateTime.TryParse(values[1].ToString(), out var supply);
                bool isExpirationDate = DateTime.TryParse(values[1].ToString(), out var expiration);
                bool isPurchase = float.TryParse(values[1].ToString(), out var purchase);

                if (!isProductID || !isQuantity || !isSupplyDate|| !isExpirationDate || !isPurchase)
                    return null;
                return new Stock()
                {
                    ProductID = productID,
                    Quantity = quantity,
                    Unit = values[2].ToString(),
                    SupplyDate = supply,
                    ExpirationDate =expiration,
                    PurchasePrice = purchase
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
