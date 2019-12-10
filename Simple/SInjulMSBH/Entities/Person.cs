using System;

namespace Simple.SInjulMSBH.Entities
{
	public class Person
	{
		public Person(
			string fullName,
			byte age,
			DateTimeOffset birthDate)
		{
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
