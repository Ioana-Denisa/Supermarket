using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class Producer
    {
        [Key]
        public int ProducerID {  get; set; }
       
        [Required]
        public string Name {  get; set; }
       
        [Required]

        public string Country {  get; set; }
       
        public Producer() {
            Name = "";
            Country = "";
        }
    }
}
