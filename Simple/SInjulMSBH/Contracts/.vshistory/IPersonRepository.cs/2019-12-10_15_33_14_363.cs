using System.Threading;
using System.Threading.Tasks;

using Simple.SInjulMSBH.Entities;

namespace Simple.SInjulMSBH.Contracts
{
	public interface IPersonRepository
	{
		Task Add(Person person, CancellationToken cancellationToken = default);
	}
}
