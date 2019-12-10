using System;

namespace Simple.SInjulMSBH.UseCases
{
	public class CreatePersonCommand
	{
		public CreatePersonCommand(
			string fullName,
			byte age,
			DateTimeOffset birthDate)
		{
			FullName = fullName;
			Age = age;
			BirthDate = birthDate;
		}

		public string FullName { get; private set; }
		public byte Age { get; private set; }
		public DateTimeOffset BirthDate { get; private set; }
	}
}
