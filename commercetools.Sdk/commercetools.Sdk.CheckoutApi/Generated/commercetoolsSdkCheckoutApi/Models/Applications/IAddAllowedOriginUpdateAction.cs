using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.AddAllowedOriginUpdateAction))]
    public partial interface IAddAllowedOriginUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string Origin { get; set; }

    }
}
