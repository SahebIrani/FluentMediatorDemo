
using System.Threading;

using FluentMediator;

using Microsoft.AspNetCore.Mvc;

using Simple.SInjulMSBH.DataTransferObjects;
using Simple.SInjulMSBH.UseCases;

namespace Simple.Controllers
{
	public class PeopleController : ControllerBase
	{
		public IMediator Mediator { get; }
		public PeopleController(IMediator mediator)
			=> Mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));

		[HttpPost]
		public async Task<IActionResult> CreateAsync(
			PersonRequest person,
			CancellationToken cancellationToken = default)
		{
			CreatePersonCommand createPersonCommand =
				new CreatePersonCommand(person.FullName, person.Age, person.BirthDate);

			CreatePersonResponse response =
				await Mediator.SendAsync<CreatePersonResponse>(
											createPersonCommand, cancellationToken);

			return Ok(response);
		}
	}
}
