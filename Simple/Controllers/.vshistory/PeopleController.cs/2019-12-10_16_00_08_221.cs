
using FluentMediator;

using Microsoft.AspNetCore.Mvc;

using Simple.SInjulMSBH.DataTransferObjects;
using Simple.SInjulMSBH.UseCases;

namespace Simple.Controllers
{
	[Route("api/[controller]"), ApiController]
	public class PeopleController : ControllerBase
	{
		public IMediator Mediator { get; }
		public PeopleController(IMediator mediator)
			=> Mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));

		[HttpPost]
		public IActionResult Post(PersonRequest person)
		{
			CreatePersonCommand createPersonCommand = new CreatePersonCommand(
				request.Name,
				request.SSN,
				request.Balance
			);

			var response = Mediator.Send<RegisterResponse>(registerCommand);

			return Ok(response);
		}
	}
}
