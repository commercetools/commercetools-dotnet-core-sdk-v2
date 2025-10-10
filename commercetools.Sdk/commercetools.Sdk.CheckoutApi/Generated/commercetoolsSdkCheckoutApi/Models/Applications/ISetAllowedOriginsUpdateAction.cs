using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowedOriginsUpdateAction))]
    public partial interface ISetAllowedOriginsUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IAllowedOrigins AllowedOrigins { get; set; }

    }
}
