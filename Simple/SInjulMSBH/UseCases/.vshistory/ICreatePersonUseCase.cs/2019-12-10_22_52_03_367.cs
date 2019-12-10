using System.Threading;
using System.Threading.Tasks;

namespace Simple.SInjulMSBH.UseCases
{
	public interface ICreatePersonUseCase
	{
		Task<CreatePersonResponse> ExecuteAsync(
			CreatePersonCommand createPersonCommand,
			CancellationToken cancellationToken = default);
	}
}
