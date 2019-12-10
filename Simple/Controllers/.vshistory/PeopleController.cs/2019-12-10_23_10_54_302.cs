
using System.Threading;
using System.Threading.Tasks;

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
		public async Task<IActionResult> CreateAsync(
			PersonRequest person,
			CancellationToken cancellationToken = default)
		{
			CreatePersonResponse response = Mediator.Send<CreatePersonResponse>(GetCreatePersonInstance(person));

			//CreatePersonResponse responseAsync =
			//	await Mediator.SendAsync<CreatePersonResponse>(GetCreatePersonInstance(person), cancellationToken);

			await Task.Run(new OkObjectResult(response))

			return Ok(response);
		}
	}
}
