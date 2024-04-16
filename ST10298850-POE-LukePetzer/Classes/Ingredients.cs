using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10298850_POE_LukePetzer.Classes
{
    internal class Ingredient
    {

        
            private string name;
            private double quantity;
            private string unitOfMeasurement;

            
            public Ingredient(string name, double quantity, string unitOfMeasurement)
            {
                this.name = name;
                this.quantity = quantity;
                this.unitOfMeasurement = unitOfMeasurement;
            }

            
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            
            public double Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

           
            public string UnitOfMeasurement
            {
                get { return unitOfMeasurement; }
                set { unitOfMeasurement = value; }
            }
        
    }
}

