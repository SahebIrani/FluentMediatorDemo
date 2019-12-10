using System;
using System.Threading;
using System.Threading.Tasks;

using Simple.Data;
using Simple.SInjulMSBH.Contracts;
using Simple.SInjulMSBH.Entities;

namespace Simple.SInjulMSBH.Infrastructures
{
	public class PersonRepository : IPersonRepository
	{
		public ApplicationDbContext Context { get; }
		public PersonRepository(ApplicationDbContext context)
			=> Context = context ?? throw new ArgumentNullException(nameof(context));

		public void Add(Person person)
		{
			Context.People.Add(person);
			Context.SaveChanges();
		}

		public async Task AddAsync(Person person, CancellationToken cancellationToken = default)
		{
			await Context.People.AddAsync(person, cancellationToken);
			await Context.SaveChangesAsync(cancellationToken);
		}
	}
}
