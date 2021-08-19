using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using szw.Model;

namespace szw.BLL
{
    public class UsersBLL : IBaseBLL<Model.Users>
    {
        private readonly DAL.UsersDAL dal = new DAL.UsersDAL();
        public int Add(Users t)
        {
            return dal.Add(t);
        }

        public int Delete(Users t)
        {
            return dal.Delete(t);
        }

        public Users GetModel(Users t)
        {
            return dal.GetModel(t);
        }

        public Users GetUsersListPage(string strWhere, int pageIndex, int pageNum)
        {
            throw new NotImplementedException();
        }

        public int Update(Users t)
        {
            throw new NotImplementedException();
        }
    }
}
