using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Ques2.Models;
using System.Data.Entity;

namespace MVC_Ques2.Models.Repository
{
    public class Repository<T>:IRepository<T>where T:class
    {
        MovieContext mc;
        DbSet<T> dbset;
        public Repository()
        {
            mc = new MovieContext();
            dbset = mc.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }
        public T GetById(object mid)
        {
            return dbset.Find(mid);
        }
        public void insert(T obj)
        {
            dbset.Add(obj);
        }
       
        public void update(T obj)
        {
            mc.Entry(obj).State = EntityState.Modified;
        }
        public void delete(object mid)
        {
            T getmodel = dbset.Find(mid);
            dbset.Remove(getmodel);
        }
        public void Save()
        {
            mc.SaveChanges();
        }

    }
}