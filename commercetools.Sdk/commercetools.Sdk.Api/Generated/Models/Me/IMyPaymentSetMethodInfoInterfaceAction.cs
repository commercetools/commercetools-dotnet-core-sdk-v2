using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction))]
    public partial interface IMyPaymentSetMethodInfoInterfaceAction : IMyPaymentUpdateAction
    {
        string Interface { get; set; }
    }
}
