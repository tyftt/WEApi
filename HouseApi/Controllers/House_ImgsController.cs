using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
namespace HouseApi.Controllers
{
    public class House_ImgsController : ApiController
    {
        House_ImgBLL bll = new House_ImgBLL();
        public int Add(House_Img t)
        {
            return bll.Add(t);
        }
    }
}
