using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftCarrier
{
    class F16 : Aircraft
    {
        public F16()
        {
            maxAmmo = 8;
            baseDmg = 30;
            this.type = "F16";
        }
    }
}
