
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class PositionBLL
    {
        PositionDAL dal = new PositionDAL();
           
        /// <summary>
        /// 职位名称绑定下拉列表
        /// </summary>
        /// <returns></returns>
        public List<Position> Show()
        {         
            return dal.Show() ;
        }    
    }
}
