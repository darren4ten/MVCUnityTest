using App.IBLL;
using App.IDAL;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class SysExceptionBLL : ISysExceptionBLL
    {
        public ISysExceptionRepository repository { get; set; }
        public List<Models.SysException> GetList(ref Common.GridPager pager, string queryStr)
        {
            using (Entities entity = new Entities())
            {
                repository.SetEntity(entity);
                IQueryable<SysException> query = repository.GetList();
                if (!string.IsNullOrEmpty(queryStr))
                {
                    query = query.Where(p => p.Message.Contains(queryStr) || p.Source.Contains(queryStr));
                }
                pager.order = string.IsNullOrEmpty(pager.order) ? "id" : pager.order.ToLower();
                pager.totalRows = repository.TotalCount();
                switch (pager.order)
                {
                    case "id":
                        {
                            query = query.OrderBy(p => p.Id);
                        }; break;
                    case "source":
                        {
                            query = query.OrderBy(p => p.Source);
                        }; break;
                    case "CreateTime":
                        {
                            query = query.OrderBy(p => p.CreateTime);
                        }; break;
                    default:
                        query = query.OrderBy(p => p.Id);
                        break;
                }
                return query.Skip(pager.rows * (pager.page - 1)).Take(pager.rows).ToList();

            }
        }

        public Models.SysException GetById(string id)
        {
            using (Entities entity = new Entities())
            {
                repository.SetEntity(entity);
                return repository.GetById(id);
            }
        }
    }
}
