using DAL.DataAcess_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess.Repositories
{
    public class UnitofWork
    {
        private readonly AppDbContext _db;

        private readonly IEmployeeRepo _employeeRepository;
        private readonly IProductRepo _productRepository;
        private readonly IDepartmentRepo _departmentRepository;
        private readonly ICategoryRepo _categoryRepository;
        




        public UnitofWork()
        {
            _db = new AppDbContext();
            _employeeRepository = new EmployeeRepo(_db);
            _productRepository = new ProductRepo(_db);
            _departmentRepository = new DepartmentRepo(_db);
            _categoryRepository = new CategoryRepo(_db);



        }
        public IProductRepo ProductRepository { get { return _productRepository; } }
        public IDepartmentRepo DepartmentRepository { get { return _departmentRepository; } }
        public ICategoryRepo CategoryRepository { get { return _categoryRepository; ; } }
        public IEmployeeRepo EmployeeRepository { get { return _employeeRepository; } }


        public void Save()
        {
            _db.SaveChanges();

        }

        


        

        
}
}
