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
    public class SysLogBLL : ISysLogBLL
    {
        [Dependency]
        public ISysLogRepository repository { get; set; }
        public List<Models.SysLog> GetList(ref Common.GridPager pager, string queryStr)
        {
            using (Entities entity = new Entities())
            {
                repository.SetEntity(entity);
                IQueryable<SysLog> query = repository.GetList();
                if (!string.IsNullOrEmpty(queryStr))
                {
                    query = query.Where(p => p.Message.Contains(queryStr) || p.Module.Contains(queryStr));
                }
                pager.order = string.IsNullOrEmpty(pager.order) ? "id" : pager.order.ToLower();
                pager.totalRows = repository.TotalCount();
                switch (pager.order)
                {
                    case "id":
                        {
                            query = query.OrderBy(p => p.Id);
                        }; break;
                    case "module":
                        {
                            query = query.OrderBy(p => p.Module);
                        }; break;
                    case "operator":
                        {
                            query = query.OrderBy(p => p.Operator);
                        }; break;
                    default:
                        query = query.OrderBy(p => p.Id);
                        break;
                }
                return query.Skip(pager.rows * (pager.page - 1)).Take(pager.rows).ToList();
            }
        }

        public Models.SysLog GetById(string id)
        {
            using (Entities entity = new Entities())
            {
                repository.SetEntity(entity);
                return repository.GetById(id);
            }
        }

        public int Create(Models.SysLog log)
        {
            using (Entities entity = new Entities())
            {
                repository.SetEntity(entity);
                return repository.Create(log);
            }
        }

        public int Delete(string[] deleteIdCollection)
        {
            using (Entities entity = new Entities())
            {
                repository.SetEntity(entity);
                return repository.Delete(deleteIdCollection);
            }
        }
    }
}
