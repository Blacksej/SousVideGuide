﻿using SousVideGuide.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    public class RecipeViewModel : BindableObject
    {

        public string RecipeName
        {
            get
            {
                return GetRecipe.RecipeName;
            }
            set
            {
                GetRecipe.RecipeName = value;
                OnPropertyChanged(nameof(RecipeName));
            }
        }

        public ObservableCollection<IngredientViewModel> Ingredients
        {
            get
            {
                ObservableCollection<IngredientViewModel> ingredientViewModels = new ObservableCollection<IngredientViewModel>();
                foreach (var item in GetRecipe.Ingredients)
                {
                    IngredientViewModel ingredientViewModel = new IngredientViewModel(item);
                    ingredientViewModels.Add(ingredientViewModel);
                }
                return ingredientViewModels;
            }
        }

        public string RecipeImage
        {
            get
            {
                return GetRecipe.RecipeImage;
            }
            set
            {
                GetRecipe.RecipeImage = value;
                OnPropertyChanged(nameof(RecipeImage));
            }
        }

        public string RecipeTime
        {
            get
            {
                return GetRecipe.RecipeTime;
            }
            set
            {
                GetRecipe.RecipeTime = value;
                OnPropertyChanged(nameof(RecipeTime));
            }
        }

        public uint RecipeTemp
        {
            get
            {
                return GetRecipe.RecipeTemp;
            }
            set
            {
                GetRecipe.RecipeTemp = value;
                OnPropertyChanged(nameof(RecipeTemp));
            }
        }

        public ImageSource Image { get => ImageSource.FromStream(() => GetRecipe.Stream); }

        public Recipe GetRecipe { get; private set; }

        public RecipeViewModel(Recipe recipe)
        {
            GetRecipe = recipe;
        }
    }
}
