using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetTransactionCustomTypeAction))]
    public partial interface IPaymentSetTransactionCustomTypeAction : IPaymentUpdateAction
    {
        string TransactionId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
