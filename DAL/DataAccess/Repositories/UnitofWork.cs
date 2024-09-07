using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess.Repositories
{
    internal class UnitofWork
    {
        private readonly AppDbContext _db;




        public UnitofWork()
        {
            _db = new AppDbContext();

        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
