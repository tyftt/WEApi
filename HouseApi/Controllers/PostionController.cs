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
    public class PostionController : ApiController
    {

        PositionBLL bll = new PositionBLL();
        /// <summary>
        /// 职位名称绑定下拉列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Position> Show()
        {
            return bll.Show();
        }
    }
}
