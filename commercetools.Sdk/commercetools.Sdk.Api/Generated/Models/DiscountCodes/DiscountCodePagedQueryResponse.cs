using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodePagedQueryResponse : IDiscountCodePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IDiscountCode> Results { get; set; }
    }
}
