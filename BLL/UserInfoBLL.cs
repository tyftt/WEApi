using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserInfoBLL
    {
        DAL.UserInfoDAL UserInfoDAL = new DAL.UserInfoDAL();
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <returns></returns>
        public DataTable DateUserInfo(string UName = "", string Hstate = "")
        {
            return UserInfoDAL.DateUserInfo(UName, Hstate);
        }
        /// <summary>
        /// 客户预约信息
        /// </summary>
        /// <returns></returns>
        public DataTable BespeakInfo()
        {
            return UserInfoDAL.BespeakInfo();
        }
        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return UserInfoDAL.Del(id);
        }
        /// <summary>
        /// 员工业绩统计
        /// </summary>
        /// <returns></returns>
        public DataTable GetSale()
        {
            return UserInfoDAL.GetSale();
        }
        /// <summary>
        /// 修改用户预约信息
        /// </summary>
        /// <param name="id">需要修改id</param>
        /// <returns></returns>
        public int DelBespeak(int id)
        {
            return UserInfoDAL.DelBespeak(id);
        }

        /// <summary>
        /// 查询员工销量
        /// </summary>
        /// <returns></returns>
        public DataTable GetScal()
        {
            return UserInfoDAL.GetScal();
        }
        /// <summary>
        /// 售出房子信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetHouseC()
        {
            return UserInfoDAL.GetHouseC();
        }

        /// <summary>
        /// 显示用户消费信息
        /// </summary>
        /// <returns></returns>
        public List<Consumption> seleShow(string name = "", int CID = 0)
        {
            return UserInfoDAL.seleShow(name,CID);
        }
    }
}
