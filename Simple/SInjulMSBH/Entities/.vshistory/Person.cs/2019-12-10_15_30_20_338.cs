using System;

namespace Simple.SInjulMSBH.Entities.vshistory.Person.cs
{
	public class Person
	{
		public Person(Guid personId, string fullName, byte age, DateTimeOffset birthDate)
		{
			PersonId = personId;
			FullName = fullName;
			Age = age;
			BirthDate = birthDate;
		}

		public Guid PersonId { get; set; }
		public string FullName { get; set; }
		public byte Age { get; set; }
		public DateTimeOffset BirthDate { get; set; }
	}
}
