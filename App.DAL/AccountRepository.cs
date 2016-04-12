using App.IDAL;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public class AccountRepository : IAccountRepository, IDisposable
    {
        public SysUser Login(string username, string pwd)
        {
            using (Entities db = new Entities())
            {
                SysUser user = db.SysUsers.SingleOrDefault(a => a.UserName == username && a.Password == pwd);
                return user;
            }
        }
        public void Dispose()
        {

        }
    }
}
