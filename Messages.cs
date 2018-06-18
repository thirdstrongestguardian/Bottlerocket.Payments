using System;
using System.Collections.Generic;

namespace MoonStorm.Payments
{
	public class Messages
	{
		public List<Message> Message { get; set; } = new List<Message>();

		public String ResultCode { get; set; }
	}
}