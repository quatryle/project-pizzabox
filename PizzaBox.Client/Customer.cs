using System;
namespace PizzaBox.Client
{
	public class customer
	{
		public customer()
		{
			Console.WriteLine("Customer Constructor called");
			customerId = 7;
			name = "Bob";
			address = "Here";
			state = "First";
		order customerorder("passedvariable"); // a linked list or dynamically allocated array of the order class

		}
		public int customerId; //Customer Number
		string name; //customer name
		string address; // customer address
		string state;
		public void newCustomer()
		{
			Console.WriteLine("Enter a Customer Name");
			string input = Console.ReadLine();
			name = input;
			Console.WriteLine("Enter a Customer State");
			input = Console.ReadLine();
			state = input;  
		Console.WriteLine("Enter a Customer Street Address");
			input = Console.ReadLine();
			state = input;  
			Console.WriteLine("Would you like a new Order?");
			int loop = 1;
			while(loop == 1)
			{
				input = Console.ReadLine();
				if(String.Compare(input,"Yes") == 0)
				{
					//customerorder.request();
					loop = 2;
				}
				else if(String.Compare(input,"No") == 0)
				{
					loop = 2;
				}
				else
				{
					Console.WriteLine("Invalid response please write Yes or No");
				}
			}
		}

		
	// [required] must be able to only order from 1 location in a 24-hour period with no reset
	// [required] must be able to only order once in a 2-hour period
	}
}