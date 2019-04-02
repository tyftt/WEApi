using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    /// <summary>
    /// 市
    /// </summary>
    public class CityBLL
    {
        CityDAL dal = new CityDAL();
        public int Add(City t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(City t)
        {
            throw new NotImplementedException();
        }

        public List<City> Show()
        {
            throw new NotImplementedException();
        }

        public List<City> ShowCity(int prov_id)
        {
            return dal.ShowCity(prov_id);
        }

        public City GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
