using ProductList;

// Initialize ProductManager and add sample data
ProductManager productManager = new ProductManager();
productManager.AddSampleData();

bool exit = false;

// Main loop for user interaction
while (!exit)
{
    ShowMainMenu();

    string userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "P":
            productManager.AddProduct();
            break;
        case "S":
            productManager.SearchProduct();
            break;
        case "L":
            productManager.ListProducts();
            break;
        case "Q":
            Console.WriteLine("Thank you for using this application");
            exit = true;
            break;
        default:
            ProductManager.DisplayErrorMessage("Invalid Selection");
            break;
    }
}

// Method to display the main menu options
static void ShowMainMenu()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("To add a new product - enter: 'P'");
    Console.WriteLine("To search for a product - enter: 'S'");
    Console.WriteLine("To list products - enter: 'L'");
    Console.WriteLine("To quit - enter: 'Q'");
    Console.ResetColor();
}