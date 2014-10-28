using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
namespace FiledRecipes.Views
{
    /// <summary>
    ///
    /// </summary>
    /// 
    public class RecipeView : ViewBase, IRecipeView
    {
        //Visar ett recept
        public void Show(IRecipe recipe)
        {
            //Visar receptets header med receptets namn
            Header = recipe.Name;
            ShowHeaderPanel();

            //Skriver ut receptets ingredienser, rad för rad
            Console.WriteLine("\nIngredienser\n============");
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            //Skriver ut receptets instruktioner, instruktion efter instruktion
            Console.WriteLine("\nGör såhär\n=========");
            int i = 1; //Används för numrering av instruktionerna

            foreach (string instruction in recipe.Instructions)
            {
                //Skriver ut formaterade rader med instruktionens nummer på en rad och sedan själva instruktionen
                Console.WriteLine("<{0}>\n{1}\n", i, instruction);
                ++i;
            }
        }
        //Visar alla recept
        public void Show(IEnumerable<IRecipe> recipes)
        {
            //För varje recept
            foreach (Recipe recipe in recipes)
            {
                //Visar receptet
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }


}