using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        IList<IPaymentReference> Payments { get; set; }

        IEnumerable<IPaymentReference> PaymentsEnumerable { set => Payments = value.ToList(); }

    }
}
