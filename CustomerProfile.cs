using System;
using System.Collections.Generic;

namespace Bottlerocket.Payments
{
	public class CustomerProfile
	{
		public String CustomerProfileId { get; set; }

		public String Description { get; set; }

		public String Email { get; set; }
		
		public String MerchantCustomerId { get; set; }

		public List<PaymentProfile> PaymentProfiles { get; set; } = new List<PaymentProfile>();

		public List<CustomerAddress> ShipToList { get; set; } = new List<CustomerAddress>();
	}
}