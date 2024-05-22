using SupermarketProject.Models.BusinessLogicLayer;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class ProducerVM:BasePropertyChanged
    {
        private ProducerBLL producerBLL;
        private string errorMessage;
        public ProducerVM()
        {
            producerBLL = new ProducerBLL(new SupermarketDBContext());
            ProducerList = producerBLL.GetAll();
        }

        public ObservableCollection<Producer> ProducerList
        {
            get => producerBLL.ProducersList;
            set => producerBLL.ProducersList = value;
        }
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                NotifyPropertyChanged("ErrorMessage");
            }
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new NonGenericCommand(Create);
                }
                return addCommand;
            }
        }

        private void Create(object parameter)
        {
            producerBLL.Add(parameter);
            ErrorMessage = producerBLL.ErrorMessage;
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new NonGenericCommand(UpdateMethod);
                }
                return updateCommand;
            }
        }

        public void UpdateMethod(object obj)
        {
            producerBLL.Update(obj);
            ErrorMessage = producerBLL.ErrorMessage;
        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new NonGenericCommand(DeleteMethod);
                }
                return deleteCommand;
            }
        }
        public void DeleteMethod(object obj)
        {
            producerBLL.Delete(obj);
            ErrorMessage = producerBLL.ErrorMessage;
        }
    }
}
