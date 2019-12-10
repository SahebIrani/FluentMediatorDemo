using System;

namespace Simple.SInjulMSBH.UseCases
{
	public class CreatePersonResponse
	{
		public CreatePersonResponse(Guid personId) => PersonId = personId;
		public Guid PersonId { get; private set; }
	}
}
