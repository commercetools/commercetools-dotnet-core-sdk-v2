using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentPagedQueryResponse : IPaymentPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IPayment> Results { get; set; }
    }
}
