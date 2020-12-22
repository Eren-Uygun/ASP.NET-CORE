using Business.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Context;

namespace Business.BaseRepository.Concrete
{
    public class BaseManager<T> : IBaseService<T> where T : class
    {
        private ProjectContext _context;
        
        public BaseManager(ProjectContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T GetByCode(string code)
        {
            return _context.Set<T>().Find(code);
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
          return  _context.Set<T>().Where(exp).FirstOrDefault();
        }
         
        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).ToList();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
