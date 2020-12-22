using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.BaseRepository.Abstract
{
   public interface IBaseService<T> where T:class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        T GetByCode(string code);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetDefault(Expression<Func<T, bool>> exp);
        List<T> GetAll();
        int Save();



    }
}
