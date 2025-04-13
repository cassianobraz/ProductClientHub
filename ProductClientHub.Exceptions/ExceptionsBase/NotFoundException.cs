using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase;

public class NotFoundException : ProductClientHubException
{
    public NotFoundException(string errorMessages) : base(errorMessages)
    {
    }

    public override List<string> GetErrors() => [Message];

    public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.NotFound;
}
