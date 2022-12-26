using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DSMRReader.Net.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using Stef.Validation;

namespace DSMRReader.Net.Factory;

public class DSMRReaderApiFactory : IDSMRReaderApiFactory
{
    public const string AuthenticationScheme = "Token";
    public static readonly Uri BaseUrl = new("http://localhost:7777/");

    public static readonly JsonSerializerSettings JsonSerializerSettings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        },
        Formatting = Formatting.Indented,
        NullValueHandling = NullValueHandling.Ignore
    };

    public IDSMRReaderApi GetApi(Uri baseUrl, string token)
    {
        Guard.NotNull(baseUrl);

        return new RestClient
        (
            baseUrl,
            (request, _) =>
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(AuthenticationScheme, token);
                return Task.CompletedTask;
            }
        )
        {
            JsonSerializerSettings = JsonSerializerSettings
        }
        .For<IDSMRReaderApi>();
    }

    public IDSMRReaderApi GetApi(string token)
    {
        return GetApi(BaseUrl, token);
    }
}