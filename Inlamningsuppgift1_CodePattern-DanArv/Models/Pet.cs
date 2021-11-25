using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv.Models
{
    public class Pet : IPet
    {
        public delegate Pet Factory(string name, ICustomer owner, bool inKennel, bool needsWash, bool needsClawTrim);

        public Pet(string name, ICustomer owner, bool inKennel, bool needsWash, bool needsClawTrim)
        {
            Name = name;
            Owner = owner;
            InKennel = inKennel;
            NeedsWash = needsWash;
            NeedsClawTrim = needsClawTrim;
        }        

        public string Name { get; set; }
        public ICustomer Owner { get ; set; }
        public bool InKennel { get; set; } = false;

        public bool NeedsWash { get; set; } = false;
        public bool NeedsClawTrim { get; set; } = false;
    }
}
