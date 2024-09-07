
using DAL.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class AppDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = .; database = ProjectCls; Integrated Security = True; Trust Server Certificate = True");
            
    }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    List<Employee> employees = new List<Employee>();
        //    List<Department> departments = new List<Department>();
        //    List<Product> products = new List<Product>();
        //    List<Bill> bills = new List<Bill>();
        //    List<Category> categories = new List<Category>();
        //    List<ProductBill> productBills = new List<ProductBill>();

        //    Random random = new Random();

        //    // إضافة بيانات الفئات (Categories)
        //    int categoryCount = random.Next(5, 10);
        //    for (int i = 1; i <= categoryCount; i++)
        //    {
        //        categories.Add(new Category
        //        {
        //            CategoryId = i,
        //            CategoryName = $"Category {i}"
        //        });
        //    }

        //    // إضافة بيانات الأقسام (Departments)
        //    int deptCount = random.Next(5, 10);
        //    for (int i = 1; i <= deptCount; i++)
        //    {
        //        departments.Add(new Department
        //        {
        //            DeptId = i,
        //            DeptName = $"Department {i}"
        //        });
        //    }

        //    // إضافة بيانات الموظفين (Employees)
        //    int empCount = random.Next(50, 100);
        //    for (int i = 1; i <= empCount; i++)
        //    {
        //        employees.Add(new Employee
        //        {
        //            EmpId = i,
        //            EmpName = $"Employee {i}",
        //            DeptId = random.Next(1, deptCount),
        //            Position = $"Position {random.Next(1, 5)}"
        //        });
        //    }

        //    // إضافة بيانات المنتجات (Products) مع الفئات (Categories)
        //    int productCount = random.Next(20, 50);
        //    for (int i = 1; i <= productCount; i++)
        //    {
        //        products.Add(new Product
        //        {
        //            ProductId = i,
        //            ProductName = $"Product {i}",
        //            Price = random.Next(50, 500), // سعر المنتج
        //            CategoryId = random.Next(1, categoryCount) // ربط المنتج بالفئة
        //        });
        //    }

        //    // إضافة بيانات الفواتير (Bills)
        //    int billCount = random.Next(10, 30);
        //    for (int i = 1; i <= billCount; i++)
        //    {
        //        bills.Add(new Bill
        //        {
        //            BillId = i,
        //            TotalPrice = 0 // سيتم حساب إجمالي السعر لاحقًا
        //        });
        //    }

        //    // إضافة بيانات الفواتير المنتجات (ProductBills) وربطها بالفواتير
        //    for (int i = 1; i <= billCount; i++)
        //    {
        //        int productInBillCount = random.Next(1, 5); // عدد المنتجات في كل فاتورة
        //        decimal totalBillPrice = 0;

        //        for (int j = 0; j < productInBillCount; j++)
        //        {
        //            int productId = random.Next(1, productCount);
        //            int quantity = random.Next(1, 5); // كمية المنتج في الفاتورة
        //            decimal productPrice = products.First(p => p.ProductId == productId).Price * quantity;

        //            productBills.Add(new ProductBill
        //            {
        //                BillId = i,
        //                ProductId = productId,
        //                Quantity = quantity,
        //                Price = productPrice // سعر المنتج مضروب في الكمية
        //            });

        //            totalBillPrice += productPrice;
        //        }

        //        // تحديث إجمالي سعر الفاتورة
        //        bills.First(b => b.BillId == i).TotalPrice = totalBillPrice;
        //    }

        // إضافة البيانات إلى الـ ModelBuilder
        //    modelBuilder.Entity<Category>().HasData(categories);
        //    modelBuilder.Entity<Department>().HasData(departments);
        //    modelBuilder.Entity<Employee>().HasData(employees);
        //    modelBuilder.Entity<Product>().HasData(products);
        //    modelBuilder.Entity<Bill>().HasData(bills);
        //    modelBuilder.Entity<ProductBill>().HasData(productBills);
        //}


        public DbSet<Bill> Bills { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBill> ProductBills { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBill>().HasKey(p
            => new { p.ProductId, p.BillId });
        }




    }
}
