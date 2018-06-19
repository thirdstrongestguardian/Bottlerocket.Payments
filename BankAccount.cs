using System;

namespace Bottlerocket.Payments
{
	public class BankAccount
	{
		public String AccountNumber { get; set; }

		public String AccountType { get; set; }

		public String BankName { get; set; }

		public ECheckType ECheckType { get; set; }

		public String NameOnAccount { get; set; }

		public String RoutingNumber { get; set; }
	}
}