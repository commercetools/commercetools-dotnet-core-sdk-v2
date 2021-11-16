using System.Collections.Generic;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryPagedQueryResponse : IInventoryPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IInventoryEntry> Results { get; set; }
    }
}
