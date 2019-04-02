using InterFace;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 市
    /// </summary>
    public class CityDAL : HouseFace<City>
    {
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

        /// <summary>
        /// 显示市
        /// </summary>
        /// <param name="prov_id"></param>
        /// <returns></returns>
        public List<City> ShowCity(int prov_id)
        {
            string sql = $"select * from City where Prov_Id={prov_id}";
            return JsonConvert.DeserializeObject<List<City>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
        }

        public City GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
