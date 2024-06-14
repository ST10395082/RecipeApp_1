using System.Collections.Generic;
using System.Windows;

namespace RecipeApp_1
{
    public partial class ViewRecipeWindow : Window
    {
        private List<Recipe> recipes;

        public ViewRecipeWindow()
        {
            InitializeComponent();
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            // Load recipes from your data source
            recipes = new List<Recipe>();

            // Example recipes
            Recipe pastaRecipe = new Recipe("Pasta");
            pastaRecipe.Ingredients.Add(new Ingredient("Pasta", 200, "grams", 300, "Grains"));
            pastaRecipe.Ingredients.Add(new Ingredient("Tomato Sauce", 150, "ml", 100, "Vegetables"));
            pastaRecipe.Steps.Add("Boil pasta.");
            pastaRecipe.Steps.Add("Add tomato sauce.");
            recipes.Add(pastaRecipe);

            Recipe pancakeRecipe = new Recipe("Pancakes");
            pancakeRecipe.Ingredients.Add(new Ingredient("Flour", 100, "grams", 200, "Grains"));
            pancakeRecipe.Ingredients.Add(new Ingredient("Milk", 200, "ml", 100, "Dairy"));
            pancakeRecipe.Ingredients.Add(new Ingredient("Egg", 1, "piece", 70, "Proteins"));
            pancakeRecipe.Steps.Add("Mix ingredients.");
            pancakeRecipe.Steps.Add("Cook on a pan.");
            recipes.Add(pancakeRecipe);

            // Display recipes in the DataGrid
            RecipeDataGrid.ItemsSource = recipes;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Code to edit recipe
            MessageBox.Show("Edit Recipe button clicked!");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
