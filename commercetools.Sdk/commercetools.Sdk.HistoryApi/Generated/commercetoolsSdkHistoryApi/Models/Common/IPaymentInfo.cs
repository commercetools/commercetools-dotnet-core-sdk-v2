using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        IList<IReference> Payments { get; set; }

        IEnumerable<IReference> PaymentsEnumerable { set => Payments = value.ToList(); }

    }
}
