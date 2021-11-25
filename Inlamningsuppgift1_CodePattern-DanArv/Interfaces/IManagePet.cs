using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv
{
    public interface IManagePet
    {
        IPet CreatePet(List<ICustomer> owners);
        void SeeAllPets(List<IPet> pets);
    }
}
