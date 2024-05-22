using Microsoft.Xaml.Behaviors;
using SupermarketProject.Models;
using SupermarketProject.ViewModels;
using System.Linq;
using System.Windows.Controls;

namespace SupermarketProject.Exceptions
{
    public class UpdateProductsCombobox : Behavior<DataGrid>
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
            if (AssociatedObject.SelectedItem != null && AssociatedObject.SelectedItem is Product selectedProduct)
            {
                var matchingProducer = ((ProductVM)AssociatedObject.DataContext).ProducerList.FirstOrDefault(producer => producer.Name == selectedProduct.Producer.Name);
                var matchingCategory = ((ProductVM)AssociatedObject.DataContext).CategoryList.FirstOrDefault(category => category.Name == selectedProduct.Category.Name);

                var comboBoxProducer = AssociatedObject.FindName("cbxProducer") as ComboBox;
                if (comboBoxProducer != null)
                {
                    comboBoxProducer.SelectedItem = matchingProducer;
                }

                var comboBoxCategory = AssociatedObject.FindName("cbxCategory") as ComboBox;
                if (comboBoxCategory != null)
                {
                    comboBoxCategory.SelectedItem = matchingCategory;
                }
            }
        }
    }
}
