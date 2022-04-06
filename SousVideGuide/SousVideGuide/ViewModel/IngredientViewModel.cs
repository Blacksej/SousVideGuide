using SousVideGuide.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    public class IngredientViewModel : BindableObject
    {
        public string NameOfIngredient
        {
            get { return GetIngredient.NameOfIngredient; }
            set 
            { 
                GetIngredient.NameOfIngredient = value;
                OnPropertyChanged(nameof(NameOfIngredient));
            }
        }

        public Ingredient GetIngredient { get; set; }

        public IngredientViewModel(Ingredient ingredient)
        {
            GetIngredient = ingredient;
        }

    }
}
