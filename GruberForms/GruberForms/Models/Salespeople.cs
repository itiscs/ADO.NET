using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GruberForms.Models
{
    public class Salespeople
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Snum { get; set; }
        public string Sname { get; set; }
        public string City { get; set; }
        public decimal Comm { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
