using App.Common;
using App.DAL;
using App.IBLL;
using App.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Common
{
    public static class LogHandler
    {
        [Dependency]
        public static ISysLogBLL logBLL { get; set; }
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="oper">操作人</param>
        /// <param name="mes">操作信息</param>
        /// <param name="result">结果</param>
        /// <param name="type">类型</param>
        /// <param name="module">操作模块</param>
        public static void WriteServiceLog(string oper, string msg, string result, string type, string module)
        {


            SysLog entity = new SysLog();
            entity.Id = ResultHelper.NewId;
            entity.Operator = oper;
            entity.Message = msg;
            entity.Result = result;
            entity.Type = type;
            entity.Module = module;
            entity.CreateTime = ResultHelper.NowTime;
            using (SysLogRepository logRepository = new SysLogRepository())
            {
                logRepository.SetEntity(new Entities());
                logRepository.Create(entity);
            }

        }
    }
}
