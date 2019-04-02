using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
    /// <summary>
    /// 房屋图片
    /// </summary>
   public class House_ImgDAL:HouseFace<House_Img>
    {
        /// <summary>
        /// 添加房屋图片
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(House_Img t)
        {
            string sql = string.Format("insert into House_img values('{0}',{1})", t.HImg, t.H_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
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
