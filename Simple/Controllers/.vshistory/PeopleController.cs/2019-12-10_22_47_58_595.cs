
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
		public async System.Threading.Tasks.Task<IActionResult> CreateAsync(PersonRequest person)
		{
			CreatePersonCommand createPersonCommand =
				new CreatePersonCommand(person.FullName, person.Age, person.BirthDate);

			CreatePersonResponse response =
				await Mediator.SendAsync<CreatePersonResponse>(createPersonCommand);

			return Ok(response);
		}
	}
}
