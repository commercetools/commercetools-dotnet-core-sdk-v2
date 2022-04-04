using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    public partial class ShippingMethodPagedQueryResponse : IShippingMethodPagedQueryResponse
    {
        public long? Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long? Offset { get; set; }

        public List<IShippingMethod> Results { get; set; }
    }
}
