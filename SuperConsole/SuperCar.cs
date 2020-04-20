using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperConsole
{
    public class SuperCar : Car
    {
        public string fuel
        {
            get => default;
            set
            {
            }
        }

        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}