using System;

public class Bankaccount
{
	private string _accountNumber;
	private string _accountHolderName;
	private decimal _balance;
	public string AccountNumber
	{
		get { return _accountNumber; }
		private set { _accountNumber = value; }
	}
	public string AccountHolderName
	{
		get { return _accountHolderName; }
		private set { _accountHolderName = value;}
	}
	public decimal Balance
	{
		get { return _balance; }
		set { _balance = value; }
	}
	public Bankaccount(string accountNumber, string accountHolderName, decimal balance)
	{
		_accountNumber = accountNumber;
		_accountHolderName = accountHolderName;
		_balance = balance;
	}
	public void DisplayAccount()
	{
        Console.WriteLine($"Accountnumber: {AccountNumber}");
		Console.WriteLine($"Accountholder name: {AccountHolderName}");
		Console.WriteLine($"Balance: {Balance}");
    }
}
