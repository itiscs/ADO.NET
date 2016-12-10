using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Onum { get; set; }
        public DateTime Odate { get; set; }

        [Display(Name ="Cумма")]
        public decimal Amt { get; set; }

        public int Snum { get; set; }
        public virtual Salesperson Salesperson { get; set; }

        public int Cnum { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
