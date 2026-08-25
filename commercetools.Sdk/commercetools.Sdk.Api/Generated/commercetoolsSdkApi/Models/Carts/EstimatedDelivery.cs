using System;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class EstimatedDelivery : IEstimatedDelivery
    {
        public DateTime? From { get; set; }

        public DateTime? Until { get; set; }
    }
}
