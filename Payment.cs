using System;

namespace Bottlerocket.Payments
{
	public class Payment
	{
		public BankAccount BankAccount { get; set; }

		public CreditCard CreditCard { get; set; }

		public OpaqueData OpaqueData { get; set; }

		public PaymentType PaymentType { get; set; }
	}
}