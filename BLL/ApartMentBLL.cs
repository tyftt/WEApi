using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
  public  class ApartMentBLL
    {
        ApartMentDAL dal = new ApartMentDAL();
        public int Add(Apartment t)
        {
            return dal.Add(t);
        }

        public int Del<I>(I id) where I : struct
        {
            return dal.Del<I>(id);
        }

        public int Upt(Apartment t)
        {
            return dal.Upt(t);
        }

        public List<Apartment> Show()
        {
            return dal.Show();
        }

        public Apartment GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
