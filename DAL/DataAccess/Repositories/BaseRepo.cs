using DAL.DataAcess_Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess.Repositories
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _db;
        protected readonly DbSet<TEntity> _dbSet;
        public BaseRepo(AppDbContext db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }
        public void Delete(int id)
        {
            var entity = FindById(id);
            _dbSet.Remove(entity);
        }

        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {

            _dbSet.Update(entity);
        }
    }
}