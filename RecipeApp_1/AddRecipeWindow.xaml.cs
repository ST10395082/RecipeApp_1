using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RecipeApp_1
{
    public partial class AddRecipeWindow : Window
    {
        private List<Ingredient> ingredients;
        private List<string> steps;

        public AddRecipeWindow()
        {
            InitializeComponent();
            ingredients = new List<Ingredient>();
            steps = new List<string>();
        }

        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            string name = IngredientNameTextBox.Text;
            int quantity = int.Parse(IngredientQuantityTextBox.Text);
            string unit = IngredientUnitTextBox.Text;
            int calories = int.Parse(IngredientCaloriesTextBox.Text);
            string foodGroup = ((ComboBoxItem)FoodGroupComboBox.SelectedItem).Content.ToString();

            Ingredient ingredient = new Ingredient(name, quantity, unit, calories, foodGroup);
            ingredients.Add(ingredient);

            IngredientsListBox.Items.Add($"{quantity} {unit} of {name}, {calories} calories, {foodGroup}");
        }

        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            Recipe recipe = new Recipe(recipeName);
            recipe.Ingredients.AddRange(ingredients);
            recipe.Steps.AddRange(StepsTextBox.Text.Split('\n'));

            // Save the recipe to a list or database here

            MessageBox.Show("Recipe saved successfully!");
        }

        private void ViewRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewRecipeWindow viewRecipeWindow = new ViewRecipeWindow();
            viewRecipeWindow.Show();
        }
    }
}

