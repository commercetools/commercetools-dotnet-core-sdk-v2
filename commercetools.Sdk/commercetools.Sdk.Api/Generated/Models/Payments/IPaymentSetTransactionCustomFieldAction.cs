using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetTransactionCustomFieldAction))]
    public partial interface IPaymentSetTransactionCustomFieldAction : IPaymentUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
