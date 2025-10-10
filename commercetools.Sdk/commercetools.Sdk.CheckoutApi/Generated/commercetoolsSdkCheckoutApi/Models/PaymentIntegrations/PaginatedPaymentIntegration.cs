using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class PaginatedPaymentIntegration : IPaginatedPaymentIntegration
    {
        public int Limit { get; set; }

        public int Offset { get; set; }

        public int Count { get; set; }

        public int Total { get; set; }

        public IList<IPaymentIntegration> Results { get; set; }

        public IEnumerable<IPaymentIntegration> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
