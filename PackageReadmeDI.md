## Info
A C# client (using [RestEase](https://github.com/canton7/RestEase)) for [DSMRReader](https://DSMRReader.com): A latent text-to-image diffusion model capable of generating photo-realistic images given any text input.

## Example
``` c#
var services = new ServiceCollection();

services.AddDSMRReaderClient(token);

var provider = services.BuildServiceProvider();

var DSMRReaderApi = provider.GetRequiredService<IDSMRReaderApi>();

var DSMRReader = await DSMRReaderApi.GetAllDSMRReaderAsync().ConfigureAwait(false);
Console.WriteLine("DSMRReader = {0}", DSMRReader?.Count);
```