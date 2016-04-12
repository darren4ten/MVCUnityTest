using App.Common;
using App.IDAL;
using App.Models;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public class SysSampleRepository : ISysSampleRepository, IDisposable
    {
        Entities db = new Entities();
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        public IQueryable<SysSample> GetList(GridPager pager)
        {

            IQueryable<SysSample> list = db.SysSamples.AsQueryable();
            pager.totalRows = GetTotalNumber();
            pager.order = string.IsNullOrEmpty(pager.order) ? "ASC" : pager.order;
            var sortedData = LinqHelper.DataSorting(list, pager.sort, pager.order);
            return LinqHelper.DataPaging<SysSample>(sortedData, pager.page, pager.rows);
            //switch (pager.order.ToLower())
            //{
            //    case "id": {
            //        return list.OrderBy(p => p.Id).Skip(pager.rows * (pager.page - 1)).Take(pager.rows);
            //    }; 
            //    case "name": {
            //        return list.OrderBy(p => p.Name).Skip(pager.rows * (pager.page - 1)).Take(pager.rows);
            //    }; 
            //    case "age": {
            //        return list.OrderBy(p => p.Age).Skip(pager.rows * (pager.page - 1)).Take(pager.rows);
            //    };
            //    case "CreateTime": {
            //        return list.OrderBy(p => p.CreateTime).Skip(pager.rows * (pager.page - 1)).Take(pager.rows);
            //    }; 
            //    default:
            //        return list.OrderBy(p => p.Id).Skip(pager.rows * (pager.page - 1)).Take(pager.rows);
            //}


        }

        public int GetTotalNumber()
        {
            return db.SysSamples.Count();
        }
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">实体</param>
        public int Create(SysSample entity)
        {
            Entities db = new Entities();
            db.SysSamples.Add(entity);
            return db.SaveChanges();
        }
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">主键ID</param>
        public int Delete(string id)
        {
            Entities db = new Entities();
            SysSample entity = db.SysSamples.SingleOrDefault(a => a.Id == id);
            if (entity != null)
            {

                db.SysSamples.Remove(entity);
            }

            return db.SaveChanges();

        }

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">实体</param>
        public int Edit(SysSample entity)
        {
            Entities db = new Entities();

            db.SysSamples.Attach(entity);
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();

        }
        /// <summary>
        /// 获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public SysSample GetById(string id)
        {
            Entities db = new Entities();
            return db.SysSamples.SingleOrDefault(a => a.Id == id);

        }
        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(string id)
        {
            Entities db = new Entities();
            SysSample entity = GetById(id);
            if (entity != null)
                return true;
            return false;

        }
        public void Dispose()
        {

        }
    }
}
