﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }
        public void TInsert(T item)
        {
            _genericDal.Insert(item);
        }

        public void TDelete(T item)
        {
            _genericDal.Delete(item);
        }

        public void TUpdate(T item)
        {
            _genericDal.Update(item);
        }

        public List<T> TGetList()
        {
            return _genericDal.GetListAll();
        }

        public List<T> TGetList(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public T TGetByID(int id)
        {
            return _genericDal.GetByID(id);
        }
    }
}
