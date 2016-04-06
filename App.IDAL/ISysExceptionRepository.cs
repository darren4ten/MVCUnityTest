using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.IDAL
{
    public interface ISysExceptionRepository
    {
        void SetEntity(Entities entity);
        int Create(SysException model);
        IQueryable<SysException> GetList();
        SysException GetById(string id);
        int TotalCount();
    }
}
