using App.IDAL;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public class SysRightRepository : ISysRightRepository, IDisposable
    {
        public List<Models.P_Sys_GetRightOperate_Result> GetPermissions(string accountId, string controller)
        {
            using (Entities entity = new Entities())
            {
                var rights = entity.P_Sys_GetRightOperate(accountId, controller).Select(p =>
                {
                    return new P_Sys_GetRightOperate_Result { IsValid = p.IsValid, KeyCode = p.KeyCode };
                });

                return rights.ToList();
            }

        }

        public void Dispose()
        {

        }
    }
}
