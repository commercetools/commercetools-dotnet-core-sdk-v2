using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentUpdate))]
    public partial interface IPaymentUpdate
    {
        long Version { get; set; }

        List<IPaymentUpdateAction> Actions { get; set; }
    }
}
