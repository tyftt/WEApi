using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
   public class BespeakDAL:HouseFace<Bespeak>
    {

        public int Add(Bespeak t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Bespeak t)
        {
            throw new NotImplementedException();
        }

        public List<Bespeak> Show()
        {
            throw new NotImplementedException();
        }

        public Bespeak GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
