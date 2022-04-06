using System;
using System.Collections.Generic;
using System.Text;

namespace SousVideGuide.Model
{
    public class Ingredient
    {
        public string NameOfIngredient { get; set; }


        public Ingredient(string nameOfIngredient)
        {
            NameOfIngredient = nameOfIngredient;
        }

    }
}
