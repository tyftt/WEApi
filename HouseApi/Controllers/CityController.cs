using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
using System.Data;
using Newtonsoft.Json;

namespace HouseApi.Controllers
{
    public class CityController : ApiController
    {
        CityBLL bll = new CityBLL();
        public int Add(City t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(City t)
        {
            throw new NotImplementedException();
        }

        public List<City> Show()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public List<City> ShowCity(int prov_id)
        {
            return  bll.ShowCity(prov_id);
        }

        public City GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
