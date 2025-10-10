using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementStatusUpdateAction))]
    public partial interface ISetApplicationAgreementStatusUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string AgreementId { get; set; }

        IApplicationAgreementStatus Status { get; set; }

    }
}
