using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftCarrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            maxAmmo = 12;
            baseDmg = 50;
            this.type = "F35";
        }
    }
}
