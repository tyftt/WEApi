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
    public class ApartmentController : ApiController
    {
        ApartMentBLL bll = new ApartMentBLL();
        [HttpPost]
        public int Add(Apartment t)
        {
            return bll.Add(t);
        }

        [HttpDelete]
        public int Del<I>(I id) where I : struct
        {
            return bll.Del<I>(id);
        }

        [HttpPut]
        public int Upt(Apartment t)
        {
            return bll.Upt(t);
        }

        [HttpGet]
        public List<Apartment> Show()
        {
            return bll.Show();
        }

        [HttpGet]
        public Apartment GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
