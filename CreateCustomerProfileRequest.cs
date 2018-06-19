using System;
using System.Collections.Generic;

namespace Bottlerocket.Payments
{
	public class CreateCustomerProfileRequest
	{
		public MerchantAuthentication MerchantAuthentication { get; set; }

		public CustomerProfile Profile { get; set; }

		public String RefId { get; set; }

		public List<CustomerAddress> ShipToList { get; set; } = new List<CustomerAddress>();

		public ValidationMode ValidationMode { get; set; }
	}
}