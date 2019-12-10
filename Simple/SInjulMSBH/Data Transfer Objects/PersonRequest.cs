using System;

namespace Simple.SInjulMSBH.DataTransferObjects
{
	public class PersonRequest
	{
		public string FullName { get; set; }
		public byte Age { get; set; }
		public DateTimeOffset BirthDate { get; set; }
	}
}
