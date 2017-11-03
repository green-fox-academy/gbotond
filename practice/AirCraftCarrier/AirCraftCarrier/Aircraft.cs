using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftCarrier
{
    class Aircraft : Carrier
    {
        public int ammoStore = 0;
        public int maxAmmo;
        public int baseDmg;
        public string type;

        List<Aircraft> planeList = new List<Aircraft>();

        public void PlaneAdder(Aircraft aircraft)
        {
            planeList.Add(aircraft);
        }

        public void GetAircraftStatus()
        {
            foreach (Aircraft plane in planeList)
            {
                Console.WriteLine("Type {0}, Ammo: {1}, Base Damage: {2}, All Damage: {3}", plane.type, plane.ammoStore, plane.baseDmg, plane.ammoStore * plane.baseDmg);
            }
        }

        public void Refill(int providedAmmo)
        {
            Console.WriteLine("Refill with {0}", providedAmmo);
            foreach (Aircraft plane in planeList)
            {
                if (providedAmmo >= plane.maxAmmo)
                {
                    plane.ammoStore = plane.maxAmmo;
                }
                else if (plane.ammoStore + providedAmmo > plane.maxAmmo)
                {
                    plane.ammoStore = plane.maxAmmo;
                }
                else
                {
                    plane.ammoStore += providedAmmo;
                }
            }
        }

        public void Fight()
        {
            foreach (Aircraft plane in planeList)
            {
                Console.WriteLine("Damage dealt during the fight by the {0}: {1}", plane.type, plane.ammoStore * plane.baseDmg);
                plane.ammoStore = 0;
            }
        }

        //public void getType()
        //{
        //    Console.WriteLine("type: {0}", )
        //}
    }
}
