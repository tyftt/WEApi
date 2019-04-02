using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
using Newtonsoft.Json;

namespace DAL
{
   public class UserInfoDAL:HouseFace<UserInfo>
    {
        public int Add(UserInfo t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(UserInfo t)
        {
            throw new NotImplementedException();
        }

        public List<UserInfo> Show()
        {
            throw new NotImplementedException();
        }

        public UserInfo GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <returns></returns>
        public DataTable DateUserInfo(string UName = "", string Hstate = "")
        {
            SqlParameter name = new SqlParameter("@U_Name", SqlDbType.VarChar);
            if (UName == null)
            {
                name.Value = "";
            }
            else
            {
                name.Value = UName;
            }
            SqlParameter state = new SqlParameter("@H_State", SqlDbType.VarChar);
            if (Hstate==null)
            {
                state.Value = "";
            }
            else
            {
                state.Value = Hstate;
            }
            SqlParameter[] parameters = { name,state};
            return DBHelper.GetDataTable("Proc_Client", parameters);
        }
        /// <summary>
        /// 客户预约信息
        /// </summary>
        /// <returns></returns>
        public DataTable BespeakInfo()
        {
            string sql = "  select * from Bespeak a,UserInfo b,House c where a.U_Id = b.U_Id and a.H_Id = c.H_Id order by a.B_Id DESC";
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            string sql = "delete  from  Bespeak where B_Id="+id;
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 员工业绩统计
        /// </summary>
        /// <returns></returns>
        public DataTable GetSale()
        {
            string sql = "select * from Sale a,Emp b,UserInfo c,House d where a.E_Id = b.E_Id and a.U_Id = c.U_Id and a.H_Id = d.H_Id";
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 修改用户预约信息
        /// </summary>
        /// <param name="id">需要修改id</param>
        /// <returns></returns>
        public int DelBespeak(int id)
        {
            string sql = "update  Bespeak set B_State=1 where B_Id=" + id;
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 查询员工销量
        /// </summary>
        /// <returns></returns>
        public DataTable GetScal()
        {
            string sql = "select * from Sale a,Emp b,UserInfo c,House d where a.E_Id=b.E_Id and a.U_Id=c.U_Id and a.H_Id=d.H_Id";
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 售出房子信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetHouseC()
        {
            string sql = "select * from House where H_State=2";
            return DBHelper.GetDataTable(sql);
        }

        /// <summary>
        /// 显示用户消费信息
        /// </summary>
        /// <returns></returns>
        public List<Consumption> seleShow(string name = "",int CID=0)
        {
            string sql = "SELECT *,case con.C_State when '0' then '全款' when '1' then '首付'else '未付款' end Statee FROM Consumption con join UserInfo Us on con.U_Id=us.U_Id join House ho on con.H_Id=ho.H_Id where Us.U_Name like '%" + name + "%'";
            if (CID!=0)
            {
                sql += "  and  C_Id="+CID;
            }
            List<Consumption> list = JsonConvert.DeserializeObject<List<Consumption>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
            return list;
        }
    }
}
