using DAL.DataAccess.Models;
using DAL.DataAcess_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess.Repositories
{
    public class DepartmentRepo : BaseRepo<Department>, IDepartmentRepo
    {
        public DepartmentRepo(AppDbContext db) : base(db)
        {
        }
    }
}
