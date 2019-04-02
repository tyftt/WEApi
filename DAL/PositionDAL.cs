using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
using System.Data;
using Newtonsoft.Json;
namespace DAL
{
   public class PositionDAL:HouseFace<Position>
    {
        public int Add(Position t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Position t)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 职位名称绑定下拉列表
        /// </summary>
        /// <returns></returns>
        public List<Position> Show()
        {
            string sql = "select * from Position";
            List<Position> list = JsonConvert.DeserializeObject<List<Position>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
            return list;
        }

        public Position GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
