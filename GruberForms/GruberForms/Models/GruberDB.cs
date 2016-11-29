using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GruberForms.Models
{
    public class GruberDBInitializer : DropCreateDatabaseAlways<GruberDB>
    {
        protected override void Seed(GruberDB context)
        {
            //****************** CUSTOMERS ***********************
            context.Customers.Add(new Customer()
            {
                Cnum = 2001,
                Cname = "Hoffman",
                City = "London",
                Rating = 100
            });
            context.Customers.Add(new Customer()
            {
                Cnum = 2002,
                Cname = "Giovanni",
                City = "Rome",
                Rating = 200
            });
            context.Customers.Add(new Customer()
            {
                Cnum = 2003,
                Cname = "Liu",
                City = "SanJose",
                Rating = 200
            });
            context.Customers.Add(new Customer()
            {
                Cnum = 2004,
                Cname = "Grass",
                City = "Berlin",
                Rating = 300
            });
            context.Customers.Add(new Customer()
            {
                Cnum = 2006,
                Cname = "Clemens",
                City = "London",
                Rating = 100
            });
            context.Customers.Add(new Customer()
            {
                Cnum = 2008,
                Cname = "Cisneros",
                City = "SanJose",
                Rating = 300
            });
            context.Customers.Add(new Customer()
            {
                Cnum = 2007,
                Cname = "Pereira",
                City = "Rome",
                Rating = 100
            });
            //****************** SALESPEOPLE ***********************
            context.Salespeople.Add(new Salespeople()
            {
                Snum = 1001,
                Sname = "Peel",
                City = "London",
                Comm = 0.12m
            });
            context.Salespeople.Add(new Salespeople()
            {
                Snum = 1002,
                Sname = "Serres",
                City = "San Jose",
                Comm = 0.13m
            });
            context.Salespeople.Add(new Salespeople()
            {
                Snum = 1004,
                Sname = "Motika",
                City = "London",
                Comm = 0.11m
            });
            context.Salespeople.Add(new Salespeople()
            {
                Snum = 1007,
                Sname = "Rifkin",
                City = "Barcelona",
                Comm = 0.15m
            });
            context.Salespeople.Add(new Salespeople()
            {
                Snum = 1003,
                Sname = "Axelrod",
                City = "New York",
                Comm = 0.1m
            });
            //****************** ORDERS ***********************
            context.Orders.Add(new Order()
            {
                Onum = 3001,
                Amt = 18.69m,
                Odate = Convert.ToDateTime("03.10.2016"),
                Cnum = 2008,
                Snum = 1007
            });
            context.Orders.Add(new Order()
            {
                Onum = 3003,
                Amt = 767.19m,
                Odate = Convert.ToDateTime("03.10.2016"),
                Cnum = 2001,
                Snum = 1001
            });
            context.Orders.Add(new Order()
            {
                Onum = 3002,
                Amt = 1900.1m,
                Odate = Convert.ToDateTime("03.10.2016"),
                Cnum = 2007,
                Snum = 1004
            });
            context.Orders.Add(new Order()
            {
                Onum = 3005,
                Amt = 5160.45m,
                Odate = Convert.ToDateTime("03.10.2016"),
                Cnum = 2003,
                Snum = 1002
            });
            context.Orders.Add(new Order()
            {
                Onum = 3006,
                Amt = 1098.16m,
                Odate = Convert.ToDateTime("03.10.2016"),
                Cnum = 2008,
                Snum = 1007
            });
            context.Orders.Add(new Order()
            {
                Onum = 3009,
                Amt = 1713.23m,
                Odate = Convert.ToDateTime("04.10.2016"),
                Cnum = 2002,
                Snum = 1003
            });
            context.Orders.Add(new Order()
            {
                Onum = 3007,
                Amt = 75.75m,
                Odate = Convert.ToDateTime("04.10.2016"),
                Cnum = 2004,
                Snum = 1002
            });
            context.Orders.Add(new Order()
            {
                Onum = 3008,
                Amt = 4723m,
                Odate = Convert.ToDateTime("05.10.2016"),
                Cnum = 2006,
                Snum = 1001
            });
            context.Orders.Add(new Order()
            {
                Onum = 3010,
                Amt = 1309.95m,
                Odate = Convert.ToDateTime("06.10.2016"),
                Cnum = 2004,
                Snum = 1002
            });
            context.Orders.Add(new Order()
            {
                Onum = 3011,
                Amt = 9891.88m,
                Odate = Convert.ToDateTime("06.10.2016"),
                Cnum = 2006,
                Snum = 1001
            });
            context.SaveChanges();
        }
    }
    public class GruberDB:DbContext
    {
        static GruberDB()
        {
            Database.SetInitializer<GruberDB>(new GruberDBInitializer());
        }

        public GruberDB():base("GruberForms")
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Salespeople> Salespeople { get; set; }
        public virtual DbSet<Order> Orders { get; set; }




    }
}
