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
   /// 区
   /// </summary>
   public class AreaDAL:HouseFace<Area>
    {
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

        /// <summary>
        /// 获取区
        /// </summary>
        /// <param name="city_id"></param>
        /// <returns></returns>
        public List<Area> ShowArea(int city_id)
        {
            string sql = $"select * from Area where city_id={city_id}";
            return JsonConvert.DeserializeObject<List<Area>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
        }

        public Area GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
