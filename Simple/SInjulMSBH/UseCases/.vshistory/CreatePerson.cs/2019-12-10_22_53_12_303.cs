using System;
using System.Threading;
using System.Threading.Tasks;

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

		public async Task<CreatePersonResponse> Execute(CreatePersonCommand createPersonCommand)
		{
			Person person = new Person(
				createPersonCommand.FullName,
				createPersonCommand.Age,
				createPersonCommand.BirthDate);

			await PersonRepository.AddAsync(person, cancellationToken);

			return new CreatePersonResponse(person.PersonId);
		}

		public async Task<CreatePersonResponse> ExecuteAsync(
			CreatePersonCommand createPersonCommand,
			CancellationToken cancellationToken = default)
		{
			Person person = new Person(
				createPersonCommand.FullName,
				createPersonCommand.Age,
				createPersonCommand.BirthDate);

			await PersonRepository.AddAsync(person, cancellationToken);

			return new CreatePersonResponse(person.PersonId);
		}
	}
}
