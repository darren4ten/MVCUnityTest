using App.IBLL;
using App.IDAL;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class HomeBLL : IHomeBLL
    {
        [Dependency]
        public IHomeRepository reposity { get; set; }
        public List<Models.SysModule> GetMenuByPersonId(string moduleId)
        {
            return reposity.GetMenuByPersonId(moduleId);
        }
    }
}
