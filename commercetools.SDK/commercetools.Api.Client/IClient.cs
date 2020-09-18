using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace commercetools.Api.Client
{
    /// <summary>
    /// This interface defines the way to communicate with commercetools API.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        /// <value>
        /// The name of the client.
        /// </value>
        string Name { get; set; }

        
        Task<T> ExecuteAsync<T>(HttpRequestMessage requestMessage);
        
        Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage);
    }
}
