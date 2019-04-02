using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
using Newtonsoft.Json;

namespace DAL
{
   public class ApartMentDAL:HouseFace<Apartment>
    {
        /// <summary>
        /// 添加户型
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(Apartment t)
        {
            string sql = string.Format("insert into Apartment values ('{0}')", t.Apartment_Name);
            return DBHelper.ExecuteNonQuery(sql);
        }


        /// <summary>
        /// 删除户型
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del<I>(I id) where I : struct
        {
            string sql = "delete from Apartment where Apartment_Id={0}" + id;
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改户型
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Upt(Apartment t)
        {
            string sql = string.Format("update Apartment set Apartment_Name='{0}' where Apartment_Id={1}", t.Apartment_Name, t.Apartment_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 显示户型
        /// </summary>
        /// <returns></returns>
        public List<Apartment> Show()
        {
            string sql = "select * from Apartment";
            return JsonConvert.DeserializeObject<List<Apartment>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
        }

        public Apartment GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
