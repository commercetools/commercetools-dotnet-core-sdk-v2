using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class OrderEditPagedQueryResponse : IOrderEditPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IOrderEdit> Results { get; set; }
    }
}
