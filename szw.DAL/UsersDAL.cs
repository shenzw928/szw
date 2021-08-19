using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using szw.Model;
using System.Data.Objects;

namespace szw.DAL
{
    public class UsersDAL : IBaseDAL<Model.Users>
    {
        public int Add(Users t)
        {
            using (Model.szwEntities zxEnt = new Model.szwEntities())
            {
                zxEnt.Users.Add(t);
                return zxEnt.SaveChanges();//执行  
            }
        }

        public int Delete(Users t)
        {
            using (Model.szwEntities zxEnt = new Model.szwEntities())
            {
                Model.Users model = zxEnt.Users.FirstOrDefault(c => c.ID == t.ID);
                if (model != null)
                {
                    zxEnt.Users.Remove(model);
                    return zxEnt.SaveChanges();//执行   
                }
                else
                {
                    return 1;
                }
            }
        }

        public Users GetModel(Users t)
        {
            using (Model.szwEntities zxEnt = new Model.szwEntities())
            {
                return zxEnt.Users.FirstOrDefault(c => c.ID == t.ID);
            }
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
