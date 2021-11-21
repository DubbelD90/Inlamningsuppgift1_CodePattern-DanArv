using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv
{
    public interface ICreateCustPetList
    {
        List<ICustomer> CreateCustomerList();
        List<IPet> CreatePetList(List<ICustomer> owner);
    }
}
