using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yonetim.DAL;

namespace Yonetim.BLL.Repository
{
    public abstract class RepositoryBase<T, ID> where T : class //Tnin tipi class olmalı.Dbset tipinde olmalı.T nin yerine baseclass da olabilir.
    {
        protected internal static MyContext dbContext;//Kalıtım ile aktarılsın ama diğer projelerden aktarılmasın..

        public virtual List<T> GetAll()
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().ToList();//Set metodu vermiş olduğumuz tipin tablosunu döndürür.
        }
        public virtual T GetByID(ID id)
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().Find(id);
        }
        public virtual void Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext(); //?? null komutu
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public virtual void Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();//?? null komutu
                dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public virtual void Update()
        {
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
