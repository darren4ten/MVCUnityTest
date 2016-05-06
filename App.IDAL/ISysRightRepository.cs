using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.IDAL
{
    public interface ISysRightRepository
    {
        List<P_Sys_GetRightOperate_Result> GetPermissions(string accountId, string controller);
    }
}
