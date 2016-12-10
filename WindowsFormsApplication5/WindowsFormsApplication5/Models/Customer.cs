using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Models
{
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cnum { get; set; }
        [MaxLength(20), MinLength(2)]
        public string Cname { get; set; }
        [MaxLength(20)]
        public string City { get; set; }
        public int Rating { get; set; }

        public int? Snum { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();



    }
}
