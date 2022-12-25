using System;
using DSMRReader.Net.Client;

namespace DSMRReader.Net.Factory;

public interface IDSMRReaderApiFactory
{
    IDSMRReaderApi GetApi(Uri baseUrl, string token);

    IDSMRReaderApi GetApi(string token);
}