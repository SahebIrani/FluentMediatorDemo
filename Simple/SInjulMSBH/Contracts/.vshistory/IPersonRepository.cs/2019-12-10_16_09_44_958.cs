using System.Threading;
using System.Threading.Tasks;

using Simple.SInjulMSBH.Entities;

namespace Simple.SInjulMSBH.Contracts
{
	public interface IPersonRepository
	{
		Task AddAsync(Person person, CancellationToken cancellationToken = default);
	}
}
