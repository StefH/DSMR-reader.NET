using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DSMRReader.Net.Client;
using DSMRReader.Net.DependencyInjection.Options;
using DSMRReader.Net.Factory;
using Microsoft.Extensions.Configuration;
using RestEase.HttpClientFactory;
using Stef.Validation;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDSMRReaderClient(this IServiceCollection services, Uri baseUrl, string token)
    {
        Guard.NotNull(services);
        Guard.NotNullOrEmpty(token);

        AddDSMRReaderClient(services, new DSMRReaderClientOptions { BaseUrl = baseUrl, Token = token });

        return services;
    }

    public static IServiceCollection AddDSMRReaderClient(this IServiceCollection services, string token)
    {
        Guard.NotNull(services);
        Guard.NotNull(token);

        AddDSMRReaderClient(services, new DSMRReaderClientOptions { BaseUrl = DSMRReaderApiFactory.BaseUrl, Token = token });

        return services;
    }

    public static IServiceCollection AddDSMRReaderClient(this IServiceCollection services, IConfigurationSection section)
    {
        Guard.NotNull(services);
        Guard.NotNull(section);

        var options = new DSMRReaderClientOptions();
        section.Bind(options);

        AddDSMRReaderClient(services, options);

        return services;
    }

    public static IServiceCollection AddDSMRReaderClient(this IServiceCollection services, Action<DSMRReaderClientOptions> optionBuilder)
    {
        Guard.NotNull(services);
        Guard.NotNull(optionBuilder);

        var options = new DSMRReaderClientOptions();
        optionBuilder(options);

        AddDSMRReaderClient(services, options);

        return services;
    }

    public static void AddDSMRReaderClient(IServiceCollection services, DSMRReaderClientOptions options)
    {
        Guard.NotNull(services);
        Guard.NotNull(options);

        services.AddOptionsWithDataAnnotationValidation(options);

        services.AddRestEaseClient<IDSMRReaderApi>(
            options.BaseUrl,
            client =>
            {
                client.JsonSerializerSettings = DSMRReaderApiFactory.JsonSerializerSettings;
            },
            (request, _) =>
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(DSMRReaderApiFactory.AuthenticationScheme, options.Token);

                return Task.CompletedTask;
            });
    }
}