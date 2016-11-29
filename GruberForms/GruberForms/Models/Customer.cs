using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GruberForms.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cnum { get; set; }
        public string Cname { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
