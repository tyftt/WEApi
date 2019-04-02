using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    /// <summary>
    /// 房屋图片
    /// </summary>
   public class House_ImgBLL
    {

        House_ImgDAL dal = new House_ImgDAL();

        public int Add(House_Img t)
        {
            return dal.Add(t);
        }
        public int Upt(House_Img t)
        {
            throw new NotImplementedException();
        }

        public List<House_Img> Show()
        {
            throw new NotImplementedException();
        }

        public House_Img GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
