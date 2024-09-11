using DAL.DataAccess.Models;
using DAL.DataAcess_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL.DataAccess.Repositories
{
    public class ProductRepo : BaseRepo<Product>, IProductRepo
    {
        public ProductRepo(AppDbContext db) : base(db)
        {
        }
    }
}
