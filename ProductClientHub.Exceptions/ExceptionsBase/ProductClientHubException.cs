using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase;

public abstract class ProductClientHubException : SystemException
{
    public ProductClientHubException(string errorMessages) : base(errorMessages)
    {
    }

    public abstract List<string> GetErrors();
    public abstract HttpStatusCode GetHttpStatusCode();
}
