using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.IO;


namespace SousVideGuide.Model
{
    public class RecipeRepository
    {
        static private List<Recipe> recipeList = new List<Recipe>();

        // This is the personal folder for the app.
        private string personalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public IEnumerable<Recipe> GetRecipes()
        {
            return recipeList;
        }

        public void CreateRecipe(Recipe recipeCreated)
        {
            recipeList.Add(recipeCreated);

            //var imageFile = Path.Combine(personalFolder, recipeCreated.RecipeImage);
            //using (var writer = File.Create(imageFile))
            //{
            //    await writer.WriteAsync(recipeCreated.Image, 0, recipeCreated.Image.Length);
            //}
        }

        //public async void ReadAll()
        //{
        //    RecipesList = new List<Recipe>();

        //    string[] files = Directory.GetFiles(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));

        //    foreach (var item in files)
        //    {
        //        using (var stream = File.OpenRead(item))
        //        {
        //            using (var ms = new MemoryStream())
        //            {
        //                stream.CopyTo(ms);
        //                RecipesList.Add(new Recipe())
        //            }
        //        }
        //    }
        //}
    }
}
