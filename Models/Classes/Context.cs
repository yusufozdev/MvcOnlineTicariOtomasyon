using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Context: DbContext
    {
        public DbSet<Administrator> Admins { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillComponent> BillComponents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expens> Expenses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesMovement> SalesMovements { get; set; }

    }
}