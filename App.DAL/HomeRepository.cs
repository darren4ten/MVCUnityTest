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
        public List<Models.SysModule> GetMenuByPersonId(string personId, string moduleId)
        {
            using (Entities db = new Entities())
            {
                var testData0=from r in db.SysRoles
                                    from u in r.SysUsers
                                    where u.Id == personId
                                    select r;
                // return db.SysModules.Where(p => p.Id != "0" && p.ParentId == moduleId).ToList();
                var testData = from m in db.SysModules
                               join rl in db.SysRights
                               on m.Id equals rl.ModuleId
                               //join r in
                               //    (from r in db.SysRoles
                               //     from u in r.SysUsers
                               //     where u.Id == personId
                               //     select r)
                               //on rl.RoleId equals r.Id
                               where rl.Rightflag == true
                               where m.ParentId == moduleId
                               where m.Id != "0"
                               select m;
                var menus =
                (
                    from m in db.SysModules
                    join rl in db.SysRights
                    on m.Id equals rl.ModuleId
                    join r in
                        (from r in db.SysRoles
                         from u in r.SysUsers
                         where u.Id == personId
                         select r)
                    on rl.RoleId equals r.Id
                    where rl.Rightflag == true
                    where m.ParentId == moduleId
                    where m.Id != "0"
                    select m
                          ).Distinct().OrderBy(a => a.Sort).ToList();
                return menus;
            }
        }

        public void Dispose()
        {

        }
    }
}
