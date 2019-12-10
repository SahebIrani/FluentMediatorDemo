using System;
using System.Threading;
using System.Threading.Tasks;

using Simple.SInjulMSBH.Contracts;
using Simple.SInjulMSBH.Entities;

namespace Simple.SInjulMSBH.Infrastructures.vshistory.PersonRepository.cs
{
	public class PersonRepository : IPersonRepository
	{
		public Task Add(Person person, CancellationToken cancellationToken = default)
		{
			throw new NotImplementedException();
		}
	}
}
