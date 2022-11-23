using System.Threading.Tasks;

namespace commercetools.Sdk.Api.Models
{
    public interface IRequestCommand<TResult>
    {
        Task<TResult> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default);
    }
}