
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

		[HttpPost]
		public async Task<IActionResult> CreateAsync(
			PersonRequest person,
			CancellationToken cancellationToken = default)
		{
			CreatePersonCommand createPersonCommand =
				new CreatePersonCommand(person.FullName, person.Age, person.BirthDate);

			CreatePersonResponse response = Mediator.Send<CreatePersonResponse>(createPersonCommand);

			CreatePersonResponse responseAsync =
				await Mediator.SendAsync<CreatePersonResponse>(createPersonCommand, cancellationToken);

			return Ok(new { response, responseAsync });
		}
	}
}
