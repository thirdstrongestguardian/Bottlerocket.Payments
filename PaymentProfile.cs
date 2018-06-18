using System;

namespace MoonStorm.Payments
{
	public class PaymentProfile
	{
		public BillingAddress BillTo { get; set; }

		public String CustomerPaymentProfileId { get; set; }

		public Payment Payment { get; set; }
	}
}