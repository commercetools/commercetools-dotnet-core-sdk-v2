using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementNameUpdateAction))]
    public partial interface ISetApplicationAgreementNameUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string AgreementId { get; set; }

        string Name { get; set; }

    }
}
