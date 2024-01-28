namespace OnlineShoppingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankaccount myAccount = new Bankaccount("192838465", "Erland", 20000);
            ShoppingCart myCart = new ShoppingCart();
            Console.WriteLine("Would you like to open the shopping menu?");
            bool isRunning = false;
            var input = Console.ReadLine().ToLower();
            if (input == "yes" ||  input == "ok")
            {
                isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("1. for adding products");
                    Console.WriteLine("2. for removing products");
                    Console.WriteLine("3. for displaying the products and total cost of cart");
                    Console.WriteLine("4. for purchasing products");

                    Console.WriteLine("Enter the number, corresponding with you choice.");
                    int choice;
                    while (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Enter one of the given numbers.");
                    }
                    switch (choice)
                    {
                        case 1:
                            myCart.AddProduct(); 
                            break;
                        case 2:
                            myCart.RemoveProduct();
                            break;
                        case 3:
                            myCart.DisplayProducts();
                            Console.WriteLine();
                            decimal totalCost = myCart.CalculateCost();
                            Console.WriteLine($"Total cost of cart: {totalCost}");
                            break;
                        case 4:
                            totalCost = myCart.CalculateCost();
                            if (totalCost > myAccount.Balance)
                            {
                                Console.WriteLine("Total cost can not exceed balance");
                            }
                            else
                            {
                                myAccount.Balance -= totalCost;
                                Console.WriteLine("You've bought the following products: ");
                                myCart.DisplayProducts();
                                Console.WriteLine();
                                Console.WriteLine($"Total cost of purchase is {totalCost}");
                                Console.WriteLine($"You have {myAccount.Balance} remaining in your bankaccount");
                            }
                            break;
                    }
                    Console.WriteLine("Would you like to continue to the menu?");
                    input = Console.ReadLine().ToLower();
                    if (input != "yes" && input != "ok")
                    {
                        Console.WriteLine("Your session has ended");
                        isRunning = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("No products added to the cart");
            }
        }
       
    }
}