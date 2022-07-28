using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        List<IReference> Payments { get; set; }

    }
}
