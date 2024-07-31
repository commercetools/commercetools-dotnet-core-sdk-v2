using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryPagedQueryResponse : IInventoryPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IInventoryEntry> Results { get; set; }

        public IEnumerable<IInventoryEntry> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
