using System.Threading;
using System.Threading.Tasks;

namespace Simple.SInjulMSBH.UseCases
{
	public interface ICreatePersonUseCase
	{
		Task<CreatePersonResponse> Execute(
			CreatePersonCommand createPersonCommand,
			CancellationToken cancellationToken = default);
	}
}
