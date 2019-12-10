using System;

using Simple.SInjulMSBH.Contracts;

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
			throw new NotImplementedException();
		}
	}
}
