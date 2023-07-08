using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUsta.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [ForeignKey("category_obj")]
        public int CategoryId  { get; set; }
        public Category category_obj { get; set; }     

        [Required]
        public double Price {get; set; }
        [ForeignKey("master_obj")]
        public int MasterID { get; set; }
        public Master master_obj { get; set; }

    }
}
