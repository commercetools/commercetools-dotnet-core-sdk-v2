using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentChangeTransactionTimestampAction))]
    public partial interface IPaymentChangeTransactionTimestampAction : IPaymentUpdateAction
    {
        string TransactionId { get; set;}
        
        DateTime Timestamp { get; set;}
    }
}
