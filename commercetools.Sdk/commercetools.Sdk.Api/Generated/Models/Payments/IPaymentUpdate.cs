using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentUpdate))]
    public partial interface IPaymentUpdate
    {
        long Version { get; set; }

        List<IPaymentUpdateAction> Actions { get; set; }
    }
}
