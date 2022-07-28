using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomFieldAction))]
    public partial interface IPaymentSetCustomFieldAction : IPaymentUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
