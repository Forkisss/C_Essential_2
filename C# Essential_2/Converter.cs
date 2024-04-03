using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Essential_2
{
	class Converter
	{

		private double usdRate;
		private double eurRate;
		private double rubRate;
		public Converter(double usd, double eur, double rub)
		{
			usdRate = usd;
			eurRate = eur;
			rubRate = rub;
		}
		public double ConvertGrnToCurrency(double amount, string currency)
		{
			switch (currency.ToLower())
			{
				case "usd":
					return amount / usdRate;
				case "eur":
					return amount / eurRate;
				case "rub":
					return amount / rubRate;
				default:
					throw new ArgumentException("Unknown currency");
			}
		}

		public double ConvertCurrencyToGrn(double amount, string currency)
		{
			switch (currency.ToLower())
			{
				case "usd":
					return amount * usdRate;
				case "eur":
					return amount * eurRate;
				case "rub":
					return amount * rubRate;
				default:
					throw new ArgumentException("Unknown currency");
			}
		}
	}



}

