
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
   /// 区
   /// </summary>
   public class AreaBLL
    {
        AreaDAL dal = new AreaDAL();
        public int Add(Area t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Area t)
        {
            throw new NotImplementedException();
        }

        public List<Area> Show()
        {
            throw new NotImplementedException();
        }
        public List<Area> ShowArea(int city_id)
        {
            return dal.ShowArea(city_id);
        }

        public Area GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
