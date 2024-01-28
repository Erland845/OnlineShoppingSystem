using System;

public class ShoppingCart
{
	private decimal _sum;
	private List<Product> _products;

	public ShoppingCart()
	{
		
		_products = new List<Product>();
	}
	public void AddProduct()
	{
       
        Console.WriteLine("Enter the name of the product");
		string productname = Console.ReadLine();
		Console.WriteLine();

		Console.WriteLine("Enter the price of the product");
		decimal price;
		while(!decimal.TryParse( Console.ReadLine(), out price))
		{
            Console.WriteLine("Invalid price. Enter a valid number for price.");
        }
		Console.WriteLine();

        Console.WriteLine("Enter the quantity of the product you'd like to add");
		int quantity;
		while (!int.TryParse(Console.ReadLine(), out quantity))
		{
			Console.WriteLine("Invalid input. Enter a valid number for quantity");
		}
		Product newproduct = new Product(productname, price, quantity);
        _products.Add(newproduct);
    }
	public void RemoveProduct()
	{
		Console.WriteLine("Enter the name of the product you'd like to remove");
		string productNameToRemove = Console.ReadLine();

		Product productToRemove = _products.FirstOrDefault(p => p.ProductName.Equals(productNameToRemove, StringComparison.OrdinalIgnoreCase));

		if (productToRemove != null)
		{
			_products.Remove(productToRemove);
			Console.WriteLine($"{productNameToRemove} removed from shoppingcart");
		}
		else
		{
			Console.WriteLine($"product with name: {productNameToRemove} not found in cart");
		}
    }
	public decimal CalculateCost()
	{
		decimal totalCost = 0;
        foreach (Product product in _products)
		{
			totalCost += product.Price;
		}
		return totalCost;
    }
	public void DisplayProducts()
	{
		Console.WriteLine("Your shoppingcart contains the following products:");
		foreach (Product product in _products)
		{
            Console.WriteLine();
            product.PrintProduct();

		}
	}
} 