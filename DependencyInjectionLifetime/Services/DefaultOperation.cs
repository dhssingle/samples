namespace DependencyInjectionLifetime.Services
{
    public class DefaultOperation : ITransientOperation, IScopedOperation, ISingletonOperation
    {
        public string OperationId { get; } = System.Guid.NewGuid().ToString()[^4..];
    }
}