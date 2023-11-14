using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Ques2.Models.Repository
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(object mid);
        void insert(T obj);
        void update(T obj);
        void delete(object mid);
        void Save();


    }
}