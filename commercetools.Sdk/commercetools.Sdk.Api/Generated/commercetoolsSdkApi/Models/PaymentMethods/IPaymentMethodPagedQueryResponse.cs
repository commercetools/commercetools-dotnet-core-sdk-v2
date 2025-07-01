using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodPagedQueryResponse))]
    public partial interface IPaymentMethodPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IPaymentMethod> Results { get; set; }

        IEnumerable<IPaymentMethod> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
