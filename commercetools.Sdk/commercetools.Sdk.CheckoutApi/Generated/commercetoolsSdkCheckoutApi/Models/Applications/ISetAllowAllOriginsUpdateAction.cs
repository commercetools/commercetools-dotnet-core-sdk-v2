using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowAllOriginsUpdateAction))]
    public partial interface ISetAllowAllOriginsUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        bool AllowAll { get; set; }

    }
}
