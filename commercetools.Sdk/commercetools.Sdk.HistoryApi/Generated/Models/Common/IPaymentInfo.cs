using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.PaymentInfo))]
    public partial interface IPaymentInfo 
    {
        List<IReference> Payments { get; set;}
    }
}
