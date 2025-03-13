using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models;

public interface IResourceQueryResponse<T>
{
    public long Count { get; set; }
    public IList<T> Results { get; set; }

    public IEnumerable<T> ResultsEnumerable { set => Results = value.ToList(); }
}