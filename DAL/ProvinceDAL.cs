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
    /// 省 
    /// </summary>
    public class ProvinceDAL : HouseFace<Province>
    {
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
        /// <summary>
        /// 显示省
        /// </summary>
        /// <returns></returns>
        public List<Province> Show()
        {
            string sql = "select * from Provence";
            return JsonConvert.DeserializeObject<List<Province>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
        }

        public Province GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
