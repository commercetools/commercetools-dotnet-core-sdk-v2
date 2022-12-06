using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client
{
    /// <summary>
    /// This interface defines the way to communicate with the Composable Commerce HTTP API.
    /// </summary>
    public interface IClient
    {
        ISerializerService SerializerService { get; }
        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        /// <value>
        /// The name of the client.
        /// </value>
        string Name { get; set; }


        Task<T> ExecuteAsync<T>(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default);

        Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default);
    }
}
