using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    /// <summary>
    /// 房屋
    /// </summary>
    public class HouseBLL
    {
        HouseDAL dal = new HouseDAL();
        public int Add(MyInfo myInfo)
        {
            return dal.Add(myInfo);
        }

        public int Del(int id)
        {
            return dal.Del(id);
        }

        public int Upt(HouseInfo t)
        {
            return dal.Upt(t);
        }
        public HouseInfo GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
        public List<HouseInfo> Show()
        {
            return dal.Show();
        }

        public DataTable GetHouseById(int id)
        {
            return dal.GetHouseById(id);
        }


        /// <summary>
        /// 根据地址和钱查询房子
        /// </summary>
        /// <param name="name"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public List<HouseInfo> SercSerchHouse(string name, int min, int max)
        {
            return dal.SercSerchHouse(name,min,max);
        }

        #region  房子信息
        /// <summary>
        /// 所有房子信息
        /// </summary>
        /// <returns></returns>
        public List<HouseInfo> All()
        {
            return dal.All();
        }
        #endregion
    }
}
