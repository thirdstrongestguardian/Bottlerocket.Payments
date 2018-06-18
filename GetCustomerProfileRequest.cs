using System;

namespace MoonStorm.Payments
{
	public class GetCustomerProfileRequest
	{
		public String CustomerProfileId { get; set; }

		public String Email { get; set; }

		public Boolean IncludeIssuerInfo { get; set; } = false;

		public MerchantAuthentication MerchantAuthentication { get; set; }

		public String MerchantCustomerId { get; set; }

		public String RefId { get; set; }

		public Boolean UnmaskExpirationDate { get; set; } = false;
	}
}