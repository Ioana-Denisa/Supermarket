using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class ProducerBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<Producer> ProducersList { get; set; }

        public ProducerBLL(SupermarketDBContext context)
        {
            _context = context;
        }

        public string ErrorMessage { get; set; }
        public void Add(object obj)
        {
            Producer producer = obj as Producer;
            if (_context.Producers.FirstOrDefault(p => p.Name == producer.Name && p.Country==producer.Country) != null)
                ErrorMessage = "Datele acestea deja exista, alegeti altele!";
            else if(producer!=null)
            {
                if (string.IsNullOrEmpty(producer.Name))
                {
                    ErrorMessage = "Numele trebuie precizat!";
                }
                else if (string.IsNullOrEmpty(producer.Country))
                {
                    ErrorMessage = "Tara trebuie precizata!";
                }
                else
                {
                    _context.Database.ExecuteSqlRaw("CreateProducer @p0,@p1", parameters: new object[] { producer.Name,producer.Country });
                    producer.ProducerID = _context.Producers.Max(item => item.ProducerID);
                    ProducersList.Add(producer);
                    ErrorMessage = "";
                }
            }
        }

        public Producer GetById(int id)
        {
            Producer p= _context.Producers.Find(id);
            if (p!=null && p.IsActive==true)
                return p;else return null;
        }

        public ObservableCollection<Producer> GetAll()
        {
            List<Producer> producer = _context.Producers.ToList();
            ObservableCollection<Producer> result = new ObservableCollection<Producer>();
            foreach (Producer prod in producer)
            {
                if(prod.IsActive)
                    result.Add(prod);
            }
            if (result.Count == 0)
                return null;
            return result;
        }

        public void Update(object obj)
        {
            Producer producer = obj as Producer;
            if (producer == null)
                ErrorMessage = "Selecteaza un productator!";
            else if (string.IsNullOrEmpty(producer.Name))
                ErrorMessage = "Numele trebuie precizat!";
            else if (string.IsNullOrEmpty(producer.Country))
                ErrorMessage = "Tara trebuie precizata!";
            else
            {
                _context.Database.ExecuteSqlRaw("UpdateProducers @p0,@p1,@p2", parameters: new object[] { producer.Name,producer.Country,producer.ProducerID });
            }

        }

        public void Delete(object obj)
        {
            Producer producer = obj as Producer;
            if (producer == null)
            {
                ErrorMessage = "Selecteaza un producer";
            }
            else if (_context.Stocks.Any(s => s.Product.ProducerID == producer.ProducerID))
            {
                ErrorMessage = "Exista produse in stoc care sunt distribuite de acest producator!";
            }
            else
            {
                _context.Database.ExecuteSqlRaw("DeleteProducer @p0", parameters: new object[] { producer.ProducerID });
                Producer prodInList = ProducersList.FirstOrDefault(i => i.ProducerID == producer.ProducerID);
                if (prodInList != null)
                {
                    prodInList.IsActive = false;
                }
                ErrorMessage = "";
            }
        }
    }
}
