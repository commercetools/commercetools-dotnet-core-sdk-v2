using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentUpdate))]
    public partial interface IPaymentUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IPaymentUpdate, IPaymentUpdateAction>
    {
        new long Version { get; set; }
        new List<IPaymentUpdateAction> Actions { get; set; }
    }
}
