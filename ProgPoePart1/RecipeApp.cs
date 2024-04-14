namespace ProgPoePart1 // Declaring the ProgPoePart1 namespace.
{
    /// <summary>
    /// Represents an application for managing recipes.
    /// </summary>
    class RecipeApp // Declaring the RecipeApp class.
    {
        /// <summary>
        /// Runs the recipe application.
        /// </summary>
        public void Run() // Method to run the recipe application.
        {
            Recipe recipe = new Recipe(); // Creating a new Recipe instance.
            recipe.EnterRecipeDetails(); // Allowing the user to enter recipe details.
            recipe.DisplayRecipe(); // Displaying the entered recipe.
            recipe.ScaleRecipe(); // Scaling the recipe.
            recipe.ResetQuantities(); // Resetting ingredient quantities.
            recipe.DisplayRecipe(); // Displaying the original recipe after resetting quantities.
            recipe.ClearRecipe(); // Clearing the recipe.
        }
    }
}
//---------------------------------------------------------------------------- End Of Line ---------------------------------------------------------------------------------------//