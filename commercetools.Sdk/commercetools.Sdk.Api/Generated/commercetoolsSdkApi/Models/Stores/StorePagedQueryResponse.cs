using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StorePagedQueryResponse : IStorePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IStore> Results { get; set; }
        public IEnumerable<IStore> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
