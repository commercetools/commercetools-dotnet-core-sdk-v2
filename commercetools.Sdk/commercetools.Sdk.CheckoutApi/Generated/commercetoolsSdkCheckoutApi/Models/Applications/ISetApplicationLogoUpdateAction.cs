using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationLogoUpdateAction))]
    public partial interface ISetApplicationLogoUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IApplicationLogo Logo { get; set; }

    }
}
