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
    /// <summary>
    /// 房屋
    /// </summary>
    public class HouseDAL:HouseFace<HouseInfo>
    {
        /// <summary>
        /// 添加房屋信息
        /// </summary>
        /// <param name="myInfo"></param>
        /// <returns></returns>
        public int Add(MyInfo myInfo)
        {
            HouseInfo t = myInfo.HouseInfo;
            string sql = string.Format("insert into House values('{0}',{1},{2},{3},{4},{5},{6},'{7}',{8},'{9}','{10}')", t.H_Name, t.H_Price, t.H_Size, t.Apartment_Id, t.Prov_Id, t.City_Id, t.Area_Id, t.H_Address, t.H_State, t.H_Detailed, t.H_HomeType);

            string sql_ = "select top 1 h_id from house order by h_id desc";
            int id = Convert.ToInt32(DBHelper.ExecuteScalar(sql_));
            House_ImgDAL dal = new House_ImgDAL();
            foreach (var item in myInfo.imgInfo)
            {
                dal.Add(new House_Img() { HImg = item, H_Id = id });
            }
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除房屋信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            string sql = "delete from House where H_Id=" + id;
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改房屋信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Upt(HouseInfo t)
        {
            string sql = string.Format("update  House set H_Name='{0}',H_Price={1},H_Size={2},Apartment_Id={3},Prov_Id={4},City_Id={5},Area_Id={6},H_Address='{7}',H_State={8},H_Detailed='{9}',H_HomeType='{10}'  where H_Id={11}", t.H_Name, t.H_Price, t.H_Size, t.Apartment_Id, t.Prov_Id, t.City_Id, t.Area_Id, t.H_Address, t.H_State, t.H_Detailed, t.H_HomeType, t.H_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public HouseInfo GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示房屋信息
        /// </summary>
        /// <returns></returns>
        public List<HouseInfo> Show()
        {
            string sql = "select a.H_Id,a.H_Name,a.H_Price,g.HImg,a.H_Address,a.H_Detailed,a.H_HomeType,a.H_Size,a.H_State,b.Apartment_Name,c.Prov_Name,d.City_Name,e.Area_Name  from House a,Apartment b,Provence c,City d,Area e ,House_Img g where a.Apartment_Id=b.Apartment_Id and a.Prov_Id=c.Prov_Id and a.City_Id=d.City_Id and a.Area_Id=e.Area_Id and a.H_Id=g.H_Id";
            return JsonConvert.DeserializeObject<List<HouseInfo>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
        }
        /// <summary>
        /// 反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetHouseById(int id)
        {
            string sql = "select  *  from House a ,Apartment b where a.Apartment_Id=b.Apartment_Id and H_Id=" + id;
            return DBHelper.GetDataTable(sql);
        }
        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Add(HouseInfo t)
        {
            throw new NotImplementedException();
        }

        #region  查询房子信息
        /// <summary>
        /// 根据地址和钱查询房子
        /// </summary>
        /// <param name="name"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public List<HouseInfo> SercSerchHouse(string name, int min, int max)
        {
            string sql = $"select *  from House  a ,House_img b ,Area c  where a.H_Id=b.H_id and a.Area_Id=c.Area_Id and a.H_Price between '{min}' and '{max}'and  c.Area_Name like '%{name}%'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<HouseInfo> list = JsonConvert.DeserializeObject<List<HouseInfo>>(JsonConvert.SerializeObject(dt));
            return list;
        } 
        #endregion
        #region  房子信息
        /// <summary>
        /// 所有房子信息
        /// </summary>
        /// <returns></returns>
        public List<HouseInfo> All()
        {
            string sql = "select *  from House  a ,House_img b ,Area c  where a.H_Id=b.H_id and a.Area_Id=c.Area_Id";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<HouseInfo> list = JsonConvert.DeserializeObject<List<HouseInfo>>(JsonConvert.SerializeObject(dt));
            return list;
        } 
        #endregion
    }
}
