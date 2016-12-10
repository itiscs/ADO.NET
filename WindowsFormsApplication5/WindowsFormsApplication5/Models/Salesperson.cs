using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Models
{
    [Table("Salespeople")]
    public class Salesperson
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Snum { get; set; }
        public string Sname { get; set; }
        public string City { get; set; }
        public decimal Comm { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        //public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    }
}
