using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
namespace HouseApi.Controllers
{
    public class Future_kController : ApiController
    {
        BLL.UserInfoBLL UserInfoBLL = new UserInfoBLL();
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable DateUserInfo(string UName = "",string Hstate = "")
        {
            return UserInfoBLL.DateUserInfo(UName,Hstate);
        }
        /// <summary>
        /// 客户预约信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable BespeakInfo()
        {
            return UserInfoBLL.BespeakInfo();
        }
        /// <summary>
        /// 员工业绩统计
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetSale()
        {
            return UserInfoBLL.GetSale();
        }

        /// <summary>
        /// 修改用户预约信息
        /// </summary>
        /// <param name="id">需要修改id</param>
        /// <returns></returns>
        
        [HttpDelete]
        public int DelBespeak(int id)
        {
            return UserInfoBLL.DelBespeak(id);
        }

        /// <summary>
        /// 查询员工销量
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetScal()
        {
            return UserInfoBLL.GetScal();
        }

        /// <summary>
        /// 售出房子信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetHouseC()
        {
            return UserInfoBLL.GetHouseC();
        }

        /// <summary>
        /// 显示用户消费信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Consumption> seleShow(string name = "", int CID = 0)
        {
            return UserInfoBLL.seleShow(name,CID);
        }

        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public int Del(int id)
        {
            return UserInfoBLL.Del(id);
        }
    }
}
