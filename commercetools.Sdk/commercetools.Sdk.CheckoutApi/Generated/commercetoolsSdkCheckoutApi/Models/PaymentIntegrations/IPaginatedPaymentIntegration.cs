using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaginatedPaymentIntegration))]
    public partial interface IPaginatedPaymentIntegration
    {
        int Limit { get; set; }

        int Offset { get; set; }

        int Count { get; set; }

        int Total { get; set; }

        IList<IPaymentIntegration> Results { get; set; }

        IEnumerable<IPaymentIntegration> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
