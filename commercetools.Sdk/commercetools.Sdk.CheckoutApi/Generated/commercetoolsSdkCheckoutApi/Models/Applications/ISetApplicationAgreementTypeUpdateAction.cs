using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTypeUpdateAction))]
    public partial interface ISetApplicationAgreementTypeUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string AgreementId { get; set; }

        IApplicationAgreementType Type { get; set; }

    }
}
