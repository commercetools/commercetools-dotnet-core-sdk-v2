using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoMethodAction))]
    public partial interface IMyPaymentSetMethodInfoMethodAction : IMyPaymentUpdateAction
    {
        string Method { get; set; }

    }
}
