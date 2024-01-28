using System;

public class Product
{
	private string _productName;
	private decimal _price;
	private int _quantity;

	public string ProductName
	{
		get { return _productName; }
		private set { _productName = value; }
	}
	public decimal Price
	{
		get { return _price; }
		private set { _price = value; }
	}
	public int Quantity
	{
		get { return _quantity; }
		private set { _quantity = value; }
	}
	public Product(string productName, decimal price, int quantity)
	{
		_productName = productName;
		_price = price;
		_quantity = quantity;
	}
	public void PrintProduct()
	{
		Console.WriteLine($"ProductName: {ProductName}");
		Console.WriteLine($"Price: {Price}");
		Console.WriteLine($"Quantity: {Quantity}");
    }
}