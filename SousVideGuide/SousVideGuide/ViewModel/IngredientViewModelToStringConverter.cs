using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    public class IngredientViewModelToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ingredientStrings = string.Empty;
            foreach (var item in (value as List<IngredientViewModel>))
            {
                ingredientStrings += item.NameOfIngredient + "\n";
            }
            return ingredientStrings;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
