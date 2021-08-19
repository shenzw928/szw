using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szw.DAL
{
    interface IBaseDAL<T> where T : class, new()
    {
        /// <summary>
        /// 增加对象
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Add(T t);
        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Delete(T t);
        /// <summary>
        /// 修改对象
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Update(T t);
        /// <summary>
        /// 获取对象 分页
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageNum"></param>
        /// <returns></returns>
        T GetUsersListPage(string strWhere, int pageIndex, int pageNum);

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        T GetModel(T t);

    }
}
