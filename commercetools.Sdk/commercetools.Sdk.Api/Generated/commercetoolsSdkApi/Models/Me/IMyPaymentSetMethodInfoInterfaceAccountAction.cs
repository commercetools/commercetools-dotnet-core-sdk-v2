using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAccountAction))]
    public partial interface IMyPaymentSetMethodInfoInterfaceAccountAction : IMyPaymentUpdateAction
    {
        string InterfaceAccount { get; set; }

    }
}
