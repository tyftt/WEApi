using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 员工
    /// </summary>
    public class EmpDAL : HouseFace<Employee>
    {
        /// <summary>
        /// 添加员工信息,员工入职
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(Employee t)
        {
            string sql = $"insert into Emp values('{t.E_Name}'," + t.E_Sex + ",'" + t.E_Age + "','" + t.E_IDCard + "','" + t.E_Address + "','" + t.E_StartTime + "','" + t.E_EndTime + "'," + t.P_Id + ",'" + t.E_Phone + "')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除员工
        /// </summary>
        /// <returns></returns>
        public int Dell(int id)
        {
            string sql = "delete from Emp where E_Id=" + id;
            return DBHelper.ExecuteNonQuery(sql);
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Upt(Employee t)
        {
            string sql = $"update Emp set E_Name='{t.E_Name}',E_Sex='{t.E_Sex}',E_Age='{t.E_Age}',E_IDCard='{t.E_IDCard}',E_Address='{t.E_Address}',E_StartTime='{t.E_StartTime}',E_EndTime='{t.E_EndTime}',P_Id='{t.P_Id}',E_Phone='{t.E_Phone}'where E_Id='{t.E_Id}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示查询员工信息
        /// </summary>
        /// <returns></returns>
        public List<Employee> SShow(string Ename = "")
        {
            string sql = "select * from Emp join Position on Emp.P_Id=Position.P_Id where Emp.E_Name like '%" + Ename + "%'";
            List<Employee> list = JsonConvert.DeserializeObject<List<Employee>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
            return list;
        }

        public Employee GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public List<Employee> Show()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 翻填员工信息
        /// </summary>
        /// <returns></returns>
        public DataTable FantianShow(string eid)
        {
            string sql = "select * from Emp join Position on Emp.P_Id=Position.P_Id";
            return DBHelper.GetDataTable(sql);
        }

        /// <summary>
        /// 员工登录
        /// </summary>
        /// <returns></returns>
        public DataTable LoginEmp(string Name, string PassWord)
        {
            SqlParameter name = new SqlParameter("@E_Name", SqlDbType.VarChar);
            name.Value = Name;
            SqlParameter pwd = new SqlParameter("@E_PassWord",SqlDbType.VarChar);
            pwd.Value = PassWord;
            SqlParameter[] sqlParameter = { name,pwd};
            return   DBHelper.GetDataTable("Proc_Login",sqlParameter);
        }





        /// <summary>
        /// 统计当月出售房型
        /// </summary>
        /// <returns></returns>
        public DataTable showCount()
        {
            string sql = "select A.Apartment_Name,count(1) number from House H join Apartment A ON H.Apartment_Id=A.Apartment_Id join Consumption C on H.H_Id=C.H_Id where datepart(MONTH,C.C_PayTime)=datepart(MONTH,GETDATE()) group by A.Apartment_Name";
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 折线图统计员工每月卖出多少房子
        /// </summary>
        /// <returns></returns>
        public DataTable EmpCount()
        {
            string sql = "select E.E_Name,count(*) num from Sale S join House H on S.H_Id=H.H_Id join Emp E on S.E_Id=E.E_Id where H.H_State=2 or datepart(MONTH,S.S_SaleTime)=datepart(MONTH,GETDATE()) group by E.E_Name";
            return DBHelper.GetDataTable(sql);
        }
    }
}
