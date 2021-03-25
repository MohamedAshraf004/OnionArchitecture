using Domainlayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;
        private DbSet<T> _entity;
        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _entity = _dbContext.Set<T>();
        }
        public T Get(int id)
        {
            return _entity.FirstOrDefault(x=>x.Id==id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public void Insert(T entity)
        {
            _entity.Add(entity);
        }

        public void Remove(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("Entity no exists");
            }
            _entity.Remove(entity);
        }

        public void Update(T entity)
        {
            entity.UpdateDate = DateTime.Now;
            var upEntity = _entity.Attach(entity);
            upEntity.State = EntityState.Modified;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

      
    }
}
