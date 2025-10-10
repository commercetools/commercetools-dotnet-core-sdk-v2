using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.RemoveAllowedOriginUpdateAction))]
    public partial interface IRemoveAllowedOriginUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string Origin { get; set; }

    }
}
