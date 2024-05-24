using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class CashierAddReceiptVM : BasePropertyChanged
    {
        private ObservableCollection<Product> products = new ObservableCollection<Product>();
        private ObservableCollection<ReceiptProducts> receiptProducts = new ObservableCollection<ReceiptProducts>();
        private float total;
        private Product selectedProduct;
        private int quantity;
        private User cashier;
        private string username;
        private string errorMessage;


        private ICommand addProductCommand;
        private ICommand saveReceiptCommand;

        public CashierAddReceiptVM()
        {
            InitializeUsersProducts();
            ReceiptProducts.CollectionChanged += (s, e) => CalculateTotalReceipt();
        }

        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                NotifyPropertyChanged("MessageError");
            }
        }
        public ObservableCollection<Product> Products
        {
            get => products;
            set
            {
                products = value;
                NotifyPropertyChanged("Products");
            }
        }

        public ObservableCollection<ReceiptProducts> ReceiptProducts
        {
            get => receiptProducts;
            set
            {
                receiptProducts = value;
                NotifyPropertyChanged("ReceiptProducts");
            }
        }

        public float Total
        {
            get => total;
            set { total = value; NotifyPropertyChanged("Total"); }
        }


        public Product SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                NotifyPropertyChanged("SelectedProduct");
            }
        }
        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                NotifyPropertyChanged("Quantity");
            }
        }

        public User Cashier
        {
            get { return cashier; }
            set
            {
                cashier = value;
                NotifyPropertyChanged("Cashier");
            }
        }

        public string Username
        {
            get => username;
            set
            {
                username=value;
                NotifyPropertyChanged("Username");
            }
        }

        public ICommand AddProductCommand => addProductCommand ?? (addProductCommand = new NonGenericCommand(AddProduct));

        public ICommand SaveReceiptCommand => saveReceiptCommand ?? (saveReceiptCommand = new NonGenericCommand(SaveReceipt));

      
        private void InitializeUsersProducts()
        {
            using (var _context = new SupermarketDBContext())
            {
                var listProducts = _context.Products.Where(p => p.IsActive).ToList();
                listProducts.ForEach(l => Products.Add(l));

            }
        }


        private void AddProduct(object obj)
        {
            if (SelectedProduct != null && Quantity > 0)
            {
                using (var _context = new SupermarketDBContext())
                {
                    var stock = _context.Stocks.FirstOrDefault(s => s.ProductID == SelectedProduct.ProductID && s.IsActiv);
                    if (stock != null && stock.Quantity > Quantity)
                    {
                        _context.Products.Attach(SelectedProduct);
                        var receiptProduct = new ReceiptProducts
                        {
                            ProductID = SelectedProduct.ProductID,
                            Quantity = Quantity,
                            Subtotal = stock.SellingPrice * Quantity,
                            //Product=SelectedProduct
                        };
                        stock.Quantity -= Quantity;
                        _context.SaveChanges();
                        ReceiptProducts.Add(receiptProduct);
                    }
                    else if(stock==null)
                        ErrorMessage="Produsul acesta nu exista in stoc";
                    else
                        ErrorMessage="Stoc insuficient pentru acest produs!";
                    var user = _context.Users.Where(u => u.Name == username).ToList();
                    foreach (var item in user)
                        Cashier = item;
                }
            }
        }

        private void SaveReceipt(object obj)
        {
            using(var _context = new SupermarketDBContext())
            {
                
                Receipt newReceipt = new Receipt()
                { 
                    UserID = Cashier.UserID,
                    ReleseDate=DateTime.Now,
                    Total=Total
                };
                _context.Receipts.Add(newReceipt);
                _context.SaveChanges();

                foreach (var receptP in ReceiptProducts)
                {
                    receptP.ReceiptID=newReceipt.ReceipID;
                    _context.ReceiptProducts.Add(receptP);
                }
                _context.SaveChanges();
                MessageBox.Show("Bonul a fost salvat!");
            }
        }

        private void CalculateTotalReceipt()
        {
            Total = ReceiptProducts.Sum(receipt => receipt.Subtotal);
        }

    }
}
