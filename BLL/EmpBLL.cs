using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    /// <summary>
    /// 员工
    /// </summary>
   public class EmpBLL
    {
        EmpDAL dal = new EmpDAL();
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(Employee t)
        {
            return dal.Add(t);
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示员工信息
        /// </summary>
        /// <returns></returns>
        public List<Employee> SShow(string Ename)
        {
            return dal.SShow(Ename); 
        }

        public Employee GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 翻填员工信息
        /// </summary>
        /// <returns></returns>
        public DataTable FantianShow(string eid)
        {
            return dal.FantianShow(eid);
        }

        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Upt(Employee t)
        {
            return dal.Upt(t);
        }
        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Dell(int id)
        {
            return dal.Dell(id);
        }
        /// <summary>
        /// 员工登录
        /// </summary>
        /// <returns></returns>
        public DataTable LoginEmp(string Name, string PassWord)
        {
            return dal.LoginEmp(Name, PassWord);
        }


        /// <summary>
        /// 统计当月出售房型
        /// </summary>
        /// <returns></returns>
        public DataTable showCount()
        {
            return dal.showCount();
        }

        /// <summary>
        /// 折线图统计员工每月卖出多少房子
        /// </summary>
        /// <returns></returns>
        public DataTable EmpCount()
        {
            return dal.EmpCount();
        }
    }
}
