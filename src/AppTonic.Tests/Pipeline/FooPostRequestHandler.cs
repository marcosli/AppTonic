namespace AppTonic.Tests.Pipeline
{
    public class FooPostRequestHandler<TRequest> : PostRequestHandlerBase<TRequest> where TRequest : IMessage { }
}