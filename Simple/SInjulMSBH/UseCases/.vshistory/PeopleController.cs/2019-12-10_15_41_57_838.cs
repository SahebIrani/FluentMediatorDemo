using FluentMediator;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Simple.SInjulMSBH.UseCases
{
	[Route("api/[controller]"), ApiController]
	public class PeopleController : ControllerBase
	{
		public IMediator Mediator { get; }
		public PeopleController(IMediator mediator)
			=> Mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));


	}
}
