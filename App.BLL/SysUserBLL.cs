using App.IBLL;
using App.IDAL;
using App.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class SysUserBLL : ISysUserBLL
    {
        [Dependency]
        public ISysRightRepository repository { get; set; }
        public List<P_Sys_GetRightOperate_Result> GetPermissions(string userId, string accountId)
        {
            return repository.GetPermissions(userId, accountId);
        }

        public void Dispose()
        {

        }
    }
}
