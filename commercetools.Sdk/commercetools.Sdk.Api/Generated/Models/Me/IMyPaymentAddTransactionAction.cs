using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentAddTransactionAction))]
    public partial interface IMyPaymentAddTransactionAction : IMyPaymentUpdateAction
    {
        ITransactionDraft Transaction { get; set; }
    }
}
