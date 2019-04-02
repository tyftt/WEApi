using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HouseApi.Controllers
{
    public class LYBController : ApiController
    {
        HouseBLL bll = new HouseBLL();
       
        /// <summary>
        /// 根据地址和钱查询房子
        /// </summary>
        /// <param name="name"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public List<HouseInfo> SercSerchHouse(string name, int min, int max)
        {
            return bll.SercSerchHouse(name, min, max);
        }

        #region  房子信息
        /// <summary>
        /// 所有房子信息
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public List<HouseInfo> All()
        {
            return bll.All();
        }
        #endregion
    }
}
