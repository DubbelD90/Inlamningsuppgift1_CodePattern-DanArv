using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv.Interfaces
{
    public interface IPet
    {
        string Name { get; set; }
        ICustomer Owner { get; set; }
        bool InKennel { get; set; }

    }
}
