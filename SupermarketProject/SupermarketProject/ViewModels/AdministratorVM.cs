using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using SupermarketProject.Views.Admin;
using SupermarketProject.Views.Cashier;
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
            user.ShowDialog();

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
            category.ShowDialog();
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
            stock.ShowDialog();
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
            product.ShowDialog();
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
            producer.ShowDialog();
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
            more.ShowDialog();
        }




        private ICommand largestRecept;
        public ICommand LargestRecept
        {
            get
            {
                if (largestRecept == null)
                    largestRecept = new NonGenericCommand(LargestReceptWindow);
                return largestRecept;
            }

        }
        private void LargestReceptWindow(object obj)
        {
            var w = new LargestReceiptCashier();
            w.ShowDialog();
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
            w.ShowDialog();
        }

        private ICommand categoryTotalPriceCommand;
        public ICommand CategoryTotalPriceCommand
        {
            get
            {
                if (categoryTotalPriceCommand == null)
                    categoryTotalPriceCommand =new  NonGenericCommand(CategoryTotalWindow);
                return categoryTotalPriceCommand;
            }
        }

        private void CategoryTotalWindow(object obj)
        {
            var w=new CategoryTotalPirce();
            w.ShowDialog();
        }


        private ICommand dailyTotalCashier;
        public ICommand DailyTotalCashier
        {
            get
            {
                if (dailyTotalCashier == null)
                    dailyTotalCashier = new NonGenericCommand(DayliCashierWindow);
                return dailyTotalCashier;
            }
        }

        private void DayliCashierWindow(object obj)
        {
            var w = new DailyTotalCashier();
            w.ShowDialog();
        }


        #endregion


        private ICommand viewReceipts;
        public ICommand ViewReceipts
        {
            get
            {
                if (viewReceipts == null)
                    viewReceipts = new NonGenericCommand(ViewReceiptsWindow);
                return viewReceipts;
            }

        }
        private void ViewReceiptsWindow(object obj)
        {
            var w = new CashierViewReceipts();
            w.ShowDialog();
        }



    }
}
