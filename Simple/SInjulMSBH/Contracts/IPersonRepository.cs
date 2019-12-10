using System.Threading;
using System.Threading.Tasks;

using Simple.SInjulMSBH.Entities;

namespace Simple.SInjulMSBH.Contracts
{
	public interface IPersonRepository
	{
		void Add(Person person);
		Task AddAsync(Person person, CancellationToken cancellationToken = default);
	}
}
