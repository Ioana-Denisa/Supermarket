using Microsoft.Xaml.Behaviors;
using SupermarketProject.Models;
using SupermarketProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SupermarketProject.Exceptions
{
    public class UpdateStockCombobox: Behavior<DataGrid>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.SelectionChanged += OnSelectionChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.SelectionChanged -= OnSelectionChanged;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AssociatedObject.SelectedItem != null && AssociatedObject.SelectedItem is Stock selectedProduct)
            {
                var matchingProducer = ((StockVM)AssociatedObject.DataContext).ProductsList.FirstOrDefault(product => product.Name == selectedProduct.Product.Name);
 

                var comboBoxProducts = AssociatedObject.FindName("cbxProducts") as ComboBox;
                if (comboBoxProducts != null)
                {
                    comboBoxProducts.SelectedItem = matchingProducer;
                }

                
            }
        }
    }
}
