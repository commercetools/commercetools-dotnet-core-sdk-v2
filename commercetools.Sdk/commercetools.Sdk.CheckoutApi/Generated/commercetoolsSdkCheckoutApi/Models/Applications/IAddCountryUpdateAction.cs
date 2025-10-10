using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.AddCountryUpdateAction))]
    public partial interface IAddCountryUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string Country { get; set; }

    }
}
