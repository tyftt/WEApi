using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
   public class SaleDAL:HouseFace<Sale>
    {
        public int Add(Sale t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Sale t)
        {
            throw new NotImplementedException();
        }

        public List<Sale> Show()
        {
            throw new NotImplementedException();
        }

        public Sale GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
