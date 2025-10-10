using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationLogo))]
    public partial interface IApplicationLogo
    {
        string Url { get; set; }

    }
}
