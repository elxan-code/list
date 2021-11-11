using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public string brand;
        public string model;
        public string doorcount;
        public Car(string brand, string model, string doorcount)
        {
            this.brand = brand;
            this.model = model;
            this.doorcount = doorcount;


        }

        public string FullInfo()
        {
            return $"Brand is: {brand}, Model is : {model}, Doorcount is : {doorcount}";


        }
    }
}