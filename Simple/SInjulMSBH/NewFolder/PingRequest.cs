namespace Simple.SInjulMSBH.NewFolder
{
    public class PingRequest
    {
        public string Message { get; }

        public PingRequest(string message)
        {
            Message = message;
        }
    }
}