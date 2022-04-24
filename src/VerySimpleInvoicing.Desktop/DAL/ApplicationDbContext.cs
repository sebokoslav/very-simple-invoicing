using Microsoft.EntityFrameworkCore;
using VerySimpleInvoicing.Desktop.Entities;

namespace VerySimpleInvoicing.Desktop.DAL
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public string DbPath { get; }

        public ApplicationDbContext()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);
            DbPath = System.IO.Path.Join(directory, "database.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentMethod>()
            .Property(b => b.Name)
            .IsRequired();

            modelBuilder.Entity<Invoice>()
            .Property(b => b.CustomerId)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.SupplierId)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.CreatedOn)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.IssuedOn)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.DeliveredOn)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.DueInDays)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.PaymentMethodId)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.Currency)
            .IsRequired();
            modelBuilder.Entity<Invoice>()
            .Property(b => b.PONumber)
            .IsRequired();

            modelBuilder.Entity<InvoiceItem>()
            .Property(b => b.InvoiceId)
            .IsRequired();
            modelBuilder.Entity<InvoiceItem>()
            .Property(b => b.ItemNo)
            .IsRequired();
            modelBuilder.Entity<InvoiceItem>()
            .Property(b => b.Name)
            .IsRequired();
            modelBuilder.Entity<InvoiceItem>()
            .Property(b => b.Amount)
            .IsRequired();
            modelBuilder.Entity<InvoiceItem>()
            .Property(b => b.Unit)
            .IsRequired();
            modelBuilder.Entity<InvoiceItem>()
            .Property(b => b.Price)
            .IsRequired();

            modelBuilder.Entity<Customer>()
            .Property(b => b.Name)
            .IsRequired();

            modelBuilder.Entity<Supplier>()
            .Property(b => b.Name)
            .IsRequired();
            modelBuilder.Entity<Supplier>()
            .Property(b => b.BusinessId)
            .IsRequired();

            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod { Id = 1, Name = Enums.PaymentMethod.BankTransfer.ToString() });
            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod { Id = 2, Name = Enums.PaymentMethod.Cash.ToString() });
        }
    }
}
