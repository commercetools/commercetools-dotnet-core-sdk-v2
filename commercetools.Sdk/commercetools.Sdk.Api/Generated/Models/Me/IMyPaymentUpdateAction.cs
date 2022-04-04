using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentUpdateAction))]
    [SubTypeDiscriminator("addTransaction", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentAddTransactionAction))]
    [SubTypeDiscriminator("changeAmountPlanned", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentChangeAmountPlannedAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetCustomFieldAction))]
    [SubTypeDiscriminator("setMethodInfoInterface", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction))]
    [SubTypeDiscriminator("setMethodInfoMethod", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoMethodAction))]
    [SubTypeDiscriminator("setMethodInfoName", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoNameAction))]
    [SubTypeDiscriminator("setTransactionCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetTransactionCustomFieldAction))]
    public partial interface IMyPaymentUpdateAction
    {
        string Action { get; set; }
    }
}
