using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAcess_Contracts
{
    public interface IUnitofWork
    {

        IEmployeeRepo EmployeeRepo { get; }

        IProductRepo ProductRepo { get; }
        IDepartmentRepo DepartmentRepo { get; }
        ICategoryRepo CategoryRepo { get; }

        void Save();
    }
}
