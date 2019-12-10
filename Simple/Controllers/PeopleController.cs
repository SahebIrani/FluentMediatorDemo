
using System.Threading;

using FluentMediator;

using Microsoft.AspNetCore.Mvc;

using Simple.SInjulMSBH.DataTransferObjects;
using Simple.SInjulMSBH.UseCases;

namespace Simple.Controllers
{
	public class PeopleController : ControllerBase
	{
		public PeopleController(IMediator mediator)
			=> Mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));
		public IMediator Mediator { get; }

		private CreatePersonCommand GetCreatePersonInstance(PersonRequest person)
				=> new CreatePersonCommand(person.FullName, person.Age, person.BirthDate);

		[HttpPost]
		public /*async Task<OkObjectResult>*/ OkObjectResult Create/*Async*/(
			PersonRequest person,
			CancellationToken cancellationToken = default)
		{
			CreatePersonResponse response = Mediator.Send<CreatePersonResponse>(GetCreatePersonInstance(person));

			//CreatePersonResponse responseAsync =
			//	await Mediator.SendAsync<CreatePersonResponse>(GetCreatePersonInstance(person), cancellationToken);

			return Ok(response);
		}
	}
}
