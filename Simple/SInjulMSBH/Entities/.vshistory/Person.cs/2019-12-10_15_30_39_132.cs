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

		public Guid PersonId { get; protected set; }
		public string FullName { get; protected set; }
		public byte Age { get; protected set; }
		public DateTimeOffset BirthDate { get; protected set; }
	}
}
