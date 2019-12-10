namespace Simple.SInjulMSBH.UseCases
{
	public interface ICreatePersonUseCase
	{
		CreatePersonResponse Execute(CreatePersonCommand createPersonCommand);
	}
}
