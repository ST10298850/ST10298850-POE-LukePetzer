// See https://aka.ms/new-console-template for more information
using ST10298850_POE_LukePetzer.Classes;

namespace ST10298850_POE
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Recipe Recipe = new Recipe();
            Console.WriteLine("Welcome to the Recipe App!");

            Recipe.Ingredients();
            
            Recipe.DisplayRecipe();
        }
    }
}