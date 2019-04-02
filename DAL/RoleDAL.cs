using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
  public  class RoleDAL:HouseFace<Role>
    {
        public int Add(Role t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Role t)
        {
            throw new NotImplementedException();
        }

        public List<Role> Show()
        {
            throw new NotImplementedException();
        }

        public Role GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
