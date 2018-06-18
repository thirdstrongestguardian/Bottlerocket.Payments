using System;
using System.Collections.Generic;

namespace MoonStorm.Payments
{
	public class CreateCustomerProfileResponse
	{
		public String CustomerProfileId { get; set; }

		public List<String> CustomerPaymentProfileIdList { get; set; } = new List<String>();

		public List<String> CustomerShippingAddressIdList { get; set; } = new List<String>();

		public Messages Messages { get; set; }

		public String RefId { get; set; }
		
		public List<String> ValidationDirectResponseList { get; set; } = new List<String>();
	}
}