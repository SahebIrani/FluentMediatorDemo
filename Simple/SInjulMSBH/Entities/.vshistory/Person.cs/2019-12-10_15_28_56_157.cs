using System;

namespace Simple.SInjulMSBH.Entities.vshistory.Person.cs
{
	public class Person
	{
		public Guid PersonId { get; set; }
		public string FullName { get; set; }
		public byte Age { get; set; }
		public DateTimeOffset BirthDate { get; set; }
	}
}
