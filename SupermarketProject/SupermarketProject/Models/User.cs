using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class User
    {
        [Key]
        public int UserID {  get; set; }
       
        [Required]
        public string Name {  get; set; }
        
        [Required]
        public  string Password {  get; set; }
      
        [Required]
        public string Type {  get; set; }
        public bool IsActive {  get; set; }
        
    }
}
