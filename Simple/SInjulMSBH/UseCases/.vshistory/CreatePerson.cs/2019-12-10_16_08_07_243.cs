using System;

using Simple.SInjulMSBH.Contracts;
using Simple.SInjulMSBH.Entities;

namespace Simple.SInjulMSBH.UseCases
{
	public class CreatePerson : ICreatePersonUseCase
	{
		public CreatePerson(IPersonRepository personRepository)
			=> PersonRepository = personRepository ??
			throw new ArgumentNullException(nameof(personRepository));
		public IPersonRepository PersonRepository { get; }


		public CreatePersonResponse Execute(CreatePersonCommand createPersonCommand)
		{
			Person person = new Person(
				createPersonCommand.FullName,
				createPersonCommand.Age,
				createPersonCommand.BirthDate);

			PersonRepository.Add(customer);

			return new RegisterResponse(customer.Id);
		}
	}
}
