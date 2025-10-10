using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.AddApplicationAgreementUpdateAction))]
    public partial interface IAddApplicationAgreementUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IApplicationAgreementDraft Agreement { get; set; }

    }
}
