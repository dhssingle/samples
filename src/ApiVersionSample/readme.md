# ASP.NET API Versioning

同时支持 URL Path Versioning、QueryString Versioning、Media Type Versioning、Header Versioning 配置

```csharp
services.AddApiVersioning(o =>
{
    o.ReportApiVersions = true;
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = ApiVersion.Default;
    o.ApiVersionReader = ApiVersionReader.Combine(
        new MediaTypeApiVersionReader(),
        new QueryStringApiVersionReader(),
        new HeaderApiVersionReader() { HeaderNames = { "x-api-version" } });
});
```

```csharp
[ApiVersion("2.0")]
[ApiController]
[Route("api/values")]
[Route("api/v{version:apiVersion}/values")]
public class ValuesV2Controller : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Version 2", "Version 2" };
    }
}
```
