using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HouseApi.Controllers
{
    public class EmpController : ApiController
    {
        EmpBLL empbll = new EmpBLL();
        ContractBLL dal = new ContractBLL();
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(Employee t)
        {
            return empbll.Add(t);
        }
        /// <summary>
        /// 显示员工信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Employee> SShow(string Ename = "")
        {
            return empbll.SShow(Ename);
        }
        /// <summary>
        /// 翻填员工信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable FantianShow(string eid)
        {
            return empbll.FantianShow(eid);
        }
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [HttpPut]
        public int Upt(Employee t)
        {
            return empbll.Upt(t);
        }
        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       [HttpPost]
        public int Dell(int id)
        {
            return empbll.Dell(id);
        }
        /// <summary>
        /// 员工登录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable LoginEmp(string Name, string PassWord)
        {
            return empbll.LoginEmp(Name, PassWord);
        }


        /// <summary>
        /// 统计当月出售房型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable showCount()
        {
            return empbll.showCount();
        }
        /// <summary>
        /// 折线图统计员工每月卖出多少房子
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DataTable EmpCount()
        {
            return empbll.EmpCount();
        }

        /// <summary>
        /// 获取合同表中最后一条记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object GetNumberOrder()
        {
            return dal.GetNumberOrder();
        }

        /// <summary>
        /// 显示合同
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Contract> Show()
        {
            return dal.Show();
        }

        /// <summary>
        /// 获取单条合同信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Contract GetShowById(int id)
        {
            return dal.GetShowById(id);
        }

        /// <summary>
        /// 添加合同信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int AddContract(Contract t)
        {
            return dal.Add(t);
        }
    }
}
