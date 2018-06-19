using System;

namespace Bottlerocket.Payments
{
	public class CreditCard
	{
		public String CardNumber { get; set; }

		public String CardType { get; set; }

		public String ExpirationDate { get; set; }

		public String IssuerNumber { get; set; }
	}
}