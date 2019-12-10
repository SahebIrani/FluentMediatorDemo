namespace Simple.SInjulMSBH.UseCases
{
	public class CreatePersonCommand
	{
		public Person(
	Guid personId,
	string fullName,
	byte age,
	CreatePersonCommand birthDate)
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
