using App.IDAL;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public class SysExceptionRepository : ISysExceptionRepository,IDisposable
    {
        protected Entities entity { get; set; }
        public void Dispose()
        {
            
        }

        public void SetEntity(Models.Entities entity)
        {
            this.entity = entity;
        }

        public int Create(Models.SysException model)
        {
            entity.SysExceptions.Add(model);
            return entity.SaveChanges();
        }

        public IQueryable<Models.SysException> GetList()
        {
            IQueryable<SysException> list = entity.SysExceptions.AsQueryable();
            return list;
        }

        public Models.SysException GetById(string id)
        {
           return entity.SysExceptions.Where(p => p.Id == id).FirstOrDefault();
        }

        public int TotalCount()
        {
            return this.GetList().Count();
        }
    }
}
