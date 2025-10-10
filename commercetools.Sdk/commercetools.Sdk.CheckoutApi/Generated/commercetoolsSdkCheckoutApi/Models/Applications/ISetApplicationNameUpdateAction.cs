using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationNameUpdateAction))]
    public partial interface ISetApplicationNameUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string Name { get; set; }

    }
}
