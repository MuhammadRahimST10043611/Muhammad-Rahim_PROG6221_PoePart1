using System; // Importing the System namespace for basic input/output operations.
using System.Linq; // Importing the LINQ namespace for array manipulation.

namespace ProgPoePart1 // Declaring the ProgPoePart1 namespace.
{
    /// <summary>
    /// Represents a recipe with ingredients and steps.
    /// </summary>
    internal class Recipe
    {
        private string[] ingredients; // Declaring a private array to store ingredients
        private string[] steps; // Declaring a private array to store steps
        private string[] originalQuantities; // Declaring a private array to store original quantities

        /// <summary>
        /// Allows the user to enter details for the recipe, including ingredients and steps.
        /// </summary>
        public void EnterRecipeDetails() // Method to enter recipe details
        {
            Console.Write("Enter the number of ingredients: "); // Prompting the user to enter the number of ingredients
            int numIngredients = int.Parse(Console.ReadLine()); // Reading the number of ingredients from the console
            ingredients = new string[numIngredients]; // Initializing the ingredients array
            originalQuantities = new string[numIngredients]; // Initializing the originalQuantities array

            for (int i = 0; i < numIngredients; i++) // Looping through each ingredient
            {
                Console.Write($"Enter ingredient {i + 1} name: "); // Prompting the user to enter the name of the ingredient
                string name = Console.ReadLine(); // Reading the name of the ingredient from the console
                Console.Write($"Enter quantity for {name}: "); // Prompting the user to enter the quantity of the ingredient
                string quantity = Console.ReadLine(); // Reading the quantity of the ingredient from the console
                Console.Write($"Enter unit of measurement for {name}: "); // Prompting the user to enter the unit of measurement for the ingredient
                string unit = Console.ReadLine(); // Reading the unit of measurement for the ingredient from the console

                ingredients[i] = $"{quantity} {unit} of {name}"; // Constructing the ingredient string
                originalQuantities[i] = $"{quantity} {unit}"; // Storing the original quantity for scaling
            }

            Console.Write("Enter the number of steps: "); // Prompting the user to enter the number of steps
            int numSteps = int.Parse(Console.ReadLine()); // Reading the number of steps from the console
            steps = new string[numSteps]; // Initializing the steps array

            for (int i = 0; i < numSteps; i++) // Looping through each step
            {
                Console.Write($"Enter step {i + 1}: "); // Prompting the user to enter the step
                steps[i] = Console.ReadLine(); // Reading the step from the console
            }
        }

        /// <summary>
        /// Displays the recipe with ingredients and steps.
        /// </summary>
        public void DisplayRecipe() // Method to display the recipe
        {
            Console.WriteLine("\nRecipe:"); // Displaying a header for the recipe
            Console.WriteLine("Ingredients:"); // Displaying a header for the ingredients
            foreach (string ingredient in ingredients) // Looping through each ingredient
            {
                Console.WriteLine(ingredient); // Displaying the ingredient
            }
            Console.WriteLine("\nSteps:"); // Displaying a header for the steps
            foreach (string step in steps) // Looping through each step
            {
                Console.WriteLine(step); // Displaying the step
            }
        }

        /// <summary>
        /// Scales the recipe based on user input.
        /// </summary>
        public void ScaleRecipe() // Method to scale the recipe
        {
            Console.Write("\nWould you like to scale the recipe? (yes/no) "); // Prompting the user to scale the recipe
            string response = Console.ReadLine().ToLower(); // Reading the user's response from the console and converting it to lowercase
            if (response == "yes") // Checking if the user wants to scale the recipe
            {
                Console.Write("Enter the scaling factor (0.5, 2, or 3): "); // Prompting the user to enter the scaling factor
                double scaleFactor; // Declaring a variable to store the scaling factor
                while (!double.TryParse(Console.ReadLine(), out scaleFactor) || !new[] { 0.5, 2, 3 }.Contains(scaleFactor)) // Validating the user's input
                {
                    Console.Write("Invalid input. Please enter 0.5, 2, or 3: "); // Prompting the user to enter a valid scaling factor
                }
                for (int i = 0; i < ingredients.Length; i++) // Looping through each ingredient
                {
                    string[] parts = ingredients[i].Split(' '); // Splitting the ingredient string into parts
                    double quantity = double.Parse(parts[0]); // Parsing the quantity of the ingredient
                    quantity *= scaleFactor; // Scaling the quantity
                    ingredients[i] = $"{quantity} {parts[1]} of {string.Join(" ", parts.Skip(3))}"; // Updating the ingredient string with the scaled quantity
                }
            }
            else // Handling the case when the user doesn't want to scale the recipe
            {
                Console.WriteLine("Invalid input. Please enter yes or no."); // Prompting the user to enter a valid response
                ScaleRecipe(); // Calling the ScaleRecipe method again for invalid input
                return; // Returning from the method
            }
            DisplayRecipe(); // Displaying the scaled recipe
        }

        /// <summary>
        /// Resets the quantities of ingredients to their original values.
        /// </summary>
        public void ResetQuantities() // Method to reset ingredient quantities
        {
            for (int i = 0; i < ingredients.Length; i++) // Looping through each ingredient
            {
                ingredients[i] = originalQuantities[i]; // Resetting the ingredient quantity to its original value
            }
        }

        /// <summary>
        /// Clears the recipe by setting ingredients, steps, and original quantities to null.
        /// </summary>
        public void ClearRecipe() // Method to clear the recipe
        {
            ingredients = null; // Setting the ingredients array to null
            steps = null; // Setting the steps array to null
            originalQuantities = null; // Setting the originalQuantities array to null
        }
    }
}
//---------------------------------------------------------------------------- End Of Line ---------------------------------------------------------------------------------------//