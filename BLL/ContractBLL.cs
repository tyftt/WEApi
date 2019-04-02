using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
  public  class ContractBLL
    {
        ContractDAL dal = new ContractDAL();
        public int Add(Contract t)
        {
            return dal.Add(t);
        }

        public List<Contract> Show()
        {
            return dal.Show();
        }

        public Contract GetShowById(int id)
        {
            return dal.GetShowById(id);
        }

        public object GetNumberOrder()
        {
            return dal.GetNumberOrder();
        }
    }
}
