public class FooService : IFooService
{
    private readonly ILogger<FooService> _logger;

    public FooService(ILogger<FooService> logger)
    {
        _logger = logger;
    }

    public string Get()
    {
        _logger.LogInformation($"Hello {nameof(FooService)}");
        return Guid.NewGuid().ToString();
    }
}