using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.IDAL
{
    public interface ISysLogRepository
    {
        void SetEntity(Entities entity);
        int Create(SysLog log);
        int Delete(string[] deleteIdCollection);
        IQueryable<SysLog> GetList();
        SysLog GetById(string id);
        int TotalCount();
    }
}
