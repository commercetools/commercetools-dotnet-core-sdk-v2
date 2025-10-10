using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.RemoveCountryUpdateAction))]
    public partial interface IRemoveCountryUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string Country { get; set; }

    }
}
