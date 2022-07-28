using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentAddTransactionAction))]
    public partial interface IMyPaymentAddTransactionAction : IMyPaymentUpdateAction
    {
        ITransactionDraft Transaction { get; set; }

    }
}
