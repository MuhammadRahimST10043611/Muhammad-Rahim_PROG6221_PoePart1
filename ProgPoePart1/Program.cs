namespace ProgPoePart1
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method that starts the program execution.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args) // Main method
        {
            RecipeApp recipeApp = new RecipeApp(); // Creating a new instance of RecipeApp
            recipeApp.Run(); // Running the recipe application
        }
    }
}