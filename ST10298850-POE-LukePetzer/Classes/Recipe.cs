using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ST10298850_POE_LukePetzer.Classes.Ingredient;
using System.Xml.Linq;

namespace ST10298850_POE_LukePetzer.Classes
{
    internal class Recipe
    {
        private Ingredient[] ingredients;
        public void Ingredients()
        {

            Console.WriteLine("Please indicated how many ingredients this recipe contains.");
            int noOfIngredients = int.Parse(Console.ReadLine());

            ingredients = new Ingredient[noOfIngredients];


            for (int i = 0; i < noOfIngredients; i++)
            {
                Console.WriteLine("Please indicate the name of the ingredient.");
                String ingredientName = Console.ReadLine();
                Console.WriteLine("Please indicate the quantity of the ingredient.");
                double ingredientQuantity = double.Parse(Console.ReadLine());
                Console.WriteLine("Please indicate the unit of measurement of the ingredient.");
                String ingredientUnitofMeasurement = Console.ReadLine();

                // Create an instance of Ingredient and store it in the array
                ingredients[i] = new Ingredient(ingredientName, ingredientQuantity, ingredientUnitofMeasurement);
            }
        
            Console.WriteLine("Please indicate the number of steps the recipe contains.");
            int ingredientNoSteps = int.Parse(Console.ReadLine());

            ingredients = new Ingredient[ingredientNoSteps];

            for (int j = 0; j < ingredientNoSteps; j++)
            {
                Console.WriteLine("Please provide a description of step " + j);
                String IngredientDescription = Console.ReadLine();
            }

            

            // string[] ArrIngredientStoring = { "name", "quantity", "unit of measurement" };
            //for (int i = 0; i < noOfIngredients; i++)
            //{
            //    Console.WriteLine("Please indicate the"+ ArrIngredientStoring[i] + "of the ingredient.");
            //    Console.ReadLine();
            //}
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe Details:");
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name} - {ingredient.Quantity} {ingredient.UnitOfMeasurement}");

               
            }
            Console.WriteLine("Recipe Setps:");

            // Display steps
            // (You need to implement the logic to store and display steps)
        }
    }
}
