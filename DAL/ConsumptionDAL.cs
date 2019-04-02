using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
   public class ConsumptionDAL:HouseFace<Consumption>
    {
        public int Add(Consumption t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Consumption t)
        {
            throw new NotImplementedException();
        }

        public List<Consumption> Show()
        {
            throw new NotImplementedException();
        }

        public Consumption GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
