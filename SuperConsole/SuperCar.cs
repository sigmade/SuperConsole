using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperConsole
{
    public class SuperCar : Car
    {

        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}