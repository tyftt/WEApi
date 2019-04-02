using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
using Newtonsoft.Json;

namespace HouseApi.Controllers
{
    public class HouseController : ApiController
    {
        HouseBLL bll = new HouseBLL();

        [HttpPost]
        public int Add(MyInfo myInfo)
        {
            return bll.Add(myInfo);
        }
        [HttpDelete]
        public int Del(int id) 
        {
            return bll.Del(id);
        }
        [HttpPut]
        public int Upt(HouseInfo t)
        {
            return bll.Upt(t);
        }
        [HttpGet]
        public HouseInfo GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public List<HouseInfo> Show()
        {
            return bll.Show();
        }
       
        [HttpGet]
        public DataTable GetHouseById(int id)
        {
            return bll.GetHouseById(id);
        }
    }
}
