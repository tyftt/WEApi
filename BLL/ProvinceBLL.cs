
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 省 
    /// </summary>
    /// <summary>
    /// 省 
    /// </summary>
    public class ProvinceBLL
    {
        ProvinceDAL dal = new ProvinceDAL();
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

        public List<Province> Show()
        {
            return dal.Show();
        }

        public Province GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
