using System;

namespace Simple.SInjulMSBH.DataTransferObjects
{
	public class PersonRequest
	{
		public Guid PersonId { get; protected set; }
		public string FullName { get; protected set; }
		public byte Age { get; protected set; }
		public DateTimeOffset BirthDate { get; protected set; }
	}
}
