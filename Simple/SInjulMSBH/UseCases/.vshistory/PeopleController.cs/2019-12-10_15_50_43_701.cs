using System.ComponentModel.DataAnnotations;

using FluentMediator;

using Microsoft.AspNetCore.Mvc;

using Simple.SInjulMSBH.DataTransferObjects;

namespace Simple.SInjulMSBH.UseCases
{
	[Route("api/[controller]"), ApiController]
	public class PeopleController : ControllerBase
	{
		public IMediator Mediator { get; }
		public PeopleController(IMediator mediator)
			=> Mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));

		[HttpPost]
		public IActionResult Post([FromBody][Required] PersonRequest person)
		{
			var registerCommand = new RegisterCommand(
				request.Name,
				request.SSN,
				request.Balance
			);

			var response = Mediator.Send<RegisterResponse>(registerCommand);

			return Ok(response);
		}
	}
}
