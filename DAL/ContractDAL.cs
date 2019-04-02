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
   public class ContractDAL:HouseFace<Contract>
    {
        /// <summary>
        /// 添加合同
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(Contract t)
        {
            string sql = $"insert into Contract values('{t.C_Number}','{t.E_Id}','{t.H_Id}','{t.U_Name}','{t.C_SignTime}','{t.C_EndTime}','{t.C_Img}','{t.C_Legal}','{t.C_Phone}','{t.C_CardId}','{t.C_Address}','{t.C_Sex}','{t.C_Birthday}','{t.C_Bank}','{t.C_BankNumber}')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Contract t)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示合同
        /// </summary>
        /// <returns></returns>
        public List<Contract> Show()
        {
            string sql = "select * from contract C join Emp E on C.E_Id=e.E_Id join House H on C.H_Id=H.H_Id";
            return JsonConvert.DeserializeObject<List<Contract>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql)));
        }

        public Contract GetShowById<I>(I id) where I : struct
        {
            string sql = "select * from Contract where C_Id=" + id;
            return JsonConvert.DeserializeObject<List<Contract>>(JsonConvert.SerializeObject(DBHelper.GetDataTable(sql))).FirstOrDefault();
        }

        /// <summary>
        /// 合同
        /// </summary>
        /// <returns></returns>
        public object GetNumberOrder()
        {
            string sql = "select top 1 C_Number from Contract order by C_Id desc";
            return DBHelper.ExecuteScalar(sql);
        }


    }
}
