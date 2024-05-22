using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using SupermarketProject.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class AdministratorVM : BasePropertyChanged
    {
        private ICommand userCommand;
        private ICommand categoryCommand;
        private ICommand producerCommand;
        private ICommand productCommand;
        private ICommand stockCommand;
        private ICommand moreCommand;

        #region First commands

        public ICommand UserCommand
        {
            get
            {
                if (userCommand == null)
                {
                    userCommand = new NonGenericCommand(UserWindow);
                }
                return userCommand;
            }
        }
        private void UserWindow(object parameter)
        {
            var user = new UserAdmin();
            user.Show();

        }

        public ICommand CategoryCommand
        {
            get
            {
                if (categoryCommand == null)
                {
                    categoryCommand = new NonGenericCommand(CategoryWindow);
                }
                return categoryCommand;
            }
        }

        private void CategoryWindow(object obj)
        {
            var category = new CategoryAdmin();
            category.Show();
        }

        public ICommand StockCommand
        {
            get
            {
                if (stockCommand == null)
                {
                    stockCommand = new NonGenericCommand(StockWindow);
                }
                return stockCommand;
            }
        }

        private void StockWindow(object obj)
        {
            var stock = new StockAdmin();
            stock.Show();
        }

        public ICommand ProductCommand
        {
            get
            {
                if (productCommand == null)
                    productCommand = new NonGenericCommand(ProductWindow);
                return productCommand;
            }
        }

        private void ProductWindow(object obj)
        {
            var product = new ProductAdmin();
            product.Show();
        }

        public ICommand ProducerCommand
        {
            get
            {
                if (producerCommand == null)
                    producerCommand = new NonGenericCommand(ProducerWindow);
                return producerCommand;
            }
        }

        private void ProducerWindow(object obj)
        {
            var producer = new ProducerAdmin();
            producer.Show();
        }

        public ICommand MoreCommand
        {
            get
            {
                if(moreCommand==null)
                    moreCommand= new NonGenericCommand(MoreWindow);
                return moreCommand;
            }
        }
        private void MoreWindow(object obj)
        {
            var more = new MoreOptions();
            more.Show();
        }
        #endregion

        #region Second Commands
        private ICommand productCategory;
        public ICommand ProductCategory
        {
            get
            {
                if (moreCommand == null)
                    moreCommand = new NonGenericCommand(ProductCategoryW);
                return moreCommand;
            }
        }

        private void ProductCategoryW(object obj)
        {
            var w=new ProductsCategoryForProducer();
            w.Show();
        }
        #endregion

    }
}
