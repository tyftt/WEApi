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
    public class AreaController : ApiController
    {
        AreaBLL bll = new AreaBLL();
        public int Add(Area t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Area t)
        {
            throw new NotImplementedException();
        }

        public List<Area> Show()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public List<Area> ShowArea(int city_id)
        {
            return bll.ShowArea(city_id);
        }

        public Area GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
