using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction))]
    public partial interface IMyPaymentSetMethodInfoInterfaceAction : IMyPaymentUpdateAction
    {
        string Interface { get; set; }

    }
}
