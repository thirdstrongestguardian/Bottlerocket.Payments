using System;
using System.Collections.Generic;

namespace Bottlerocket.Payments
{
	public class GetCustomerProfileResponse
	{
		public Types.Messages Messages { get; set; }

		public CustomerProfile Profile { get; set; }

		public String RefId { get; set; }

		public List<String> SubscriptionIds { get; set; } = new List<String>();
	}
}