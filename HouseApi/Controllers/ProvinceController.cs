using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
namespace HouseApi.Controllers
{
    public class ProvinceController : ApiController
    {
        ProvinceBLL bll = new ProvinceBLL();
        public int Add(Province t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Province t)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public List<Province> Show()
        {
            return bll.Show();
        }

        public Province GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
