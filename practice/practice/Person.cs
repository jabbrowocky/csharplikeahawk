using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Person
    {
        public bool isThirsty;
        public string name;
        public DateTime dateOfBirth;

        public void TakeDrink(Can can)
        {
            if(can.percentageFull > 0)
            {
                can.ReduceVolume();
                isThirsty = false;
            }
        }
    }
}
