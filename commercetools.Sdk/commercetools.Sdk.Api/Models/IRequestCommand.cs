using System.Threading.Tasks;

namespace commercetools.Api.Models
{
    public interface IRequestCommand<TResult> {
        Task<TResult> ExecuteAsync();
    }
}