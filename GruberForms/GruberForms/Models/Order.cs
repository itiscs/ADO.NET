using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GruberForms.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Onum { get; set; }
        public DateTime Odate { get; set; }
        public decimal Amt { get; set; }
        public int Cnum { get; set; }
        public int Snum { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Salespeople Salespeople { get; set; }
    }
}
