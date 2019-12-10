using System;

namespace Simple.SInjulMSBH.UseCases
{
	public class CreatePersonCommand
	{
		public CreatePersonCommand(
			Guid personId,
			string fullName,
			byte age,
			DateTimeOffset birthDate)
		{
			PersonId = personId == null ? Guid.NewGuid() : personId;
			FullName = fullName;
			Age = age;
			BirthDate = birthDate;
		}

		public Guid PersonId { get; private set; }
		public string FullName { get; private set; }
		public byte Age { get; private set; }
		public DateTimeOffset BirthDate { get; private set; }
	}
}
