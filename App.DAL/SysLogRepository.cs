using App.IDAL;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public class SysLogRepository : ISysLogRepository, IDisposable
    {
        public void Dispose()
        {

        }
        protected Entities entity { get; set; }
        public void SetEntity(Entities entity)
        {
            this.entity = entity;
        }

        public int Create(Models.SysLog log)
        {
            entity.SysLogs.Add(log);
            entity.Entry(log).State = System.Data.Entity.EntityState.Added;
            return entity.SaveChanges();

        }

        public int Delete(string[] deleteIdCollection)
        {
            entity.SysLogs.RemoveRange(entity.SysLogs.Where(p => deleteIdCollection.Contains(p.Id)));
            return entity.SaveChanges();
        }

        public IQueryable<Models.SysLog> GetList()
        {
            return entity.SysLogs.AsQueryable();
        }

        public Models.SysLog GetById(string id)
        {
            return entity.SysLogs.Where(p => p.Id == id).FirstOrDefault();
        }

        public int TotalCount()
        {
            return this.GetList().Count();
        }
    }
}
