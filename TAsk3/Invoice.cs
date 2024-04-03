using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk3
{
	internal class Invoice
	{
		public readonly int Account;
		public readonly string Customer;
		public readonly string Provider;

		private string article;
		private int quantity;

		public Invoice(int account, string customer, string provider)
		{
			Account = account;
			Customer = customer;
			Provider = provider;
		}

		public void SetOrderDetails(string article, int quantity)
		{
			this.article = article;
			this.quantity = quantity;
		}

		public void CalculatePayment(bool includeVAT)
		{
			double pricePerItem = GetPricePerItem(article); 
			double totalCost = pricePerItem * quantity;
			if (includeVAT)
			{
				const double VATRate = 0.2; 
				totalCost *= (1 + VATRate);
			}

			Console.WriteLine($"Сума оплати за '{article}' (Кількість: {quantity})" +
							  $"{(includeVAT ? " з ПДВ: ":" без ПДВ: ")}{totalCost:C2}");
		}
		private double GetPricePerItem(string article)
		{
			
			return 100.0; 
		}

	}
}
