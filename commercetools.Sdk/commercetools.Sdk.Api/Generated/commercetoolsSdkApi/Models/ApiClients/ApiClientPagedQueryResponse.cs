using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ApiClients
{

    public partial class ApiClientPagedQueryResponse : IApiClientPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IApiClient> Results { get; set; }

        public IEnumerable<IApiClient> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
