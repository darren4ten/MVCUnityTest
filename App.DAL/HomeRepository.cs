using App.IDAL;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public class HomeRepository : IHomeRepository, IDisposable
    {
        public List<Models.SysModule> GetMenuByPersonId(string moduleId)
        {
            using (Entities entity = new Entities())
            {
                return entity.SysModules.Where(p => p.Id != "0" && p.ParentId == moduleId).ToList();
            }
        }

        public void Dispose()
        {

        }
    }
}
