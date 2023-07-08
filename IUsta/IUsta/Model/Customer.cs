using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUsta.Model
{
    public class Customer : User
    {
        [Required]
        public string Company { get; set; }

        public List<Master> Workers = new List<Master>();        
    }
}
