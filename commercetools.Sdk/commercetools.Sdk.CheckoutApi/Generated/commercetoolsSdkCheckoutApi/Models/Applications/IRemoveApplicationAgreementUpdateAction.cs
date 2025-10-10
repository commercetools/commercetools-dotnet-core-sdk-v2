using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.RemoveApplicationAgreementUpdateAction))]
    public partial interface IRemoveApplicationAgreementUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string AgreementId { get; set; }

    }
}
