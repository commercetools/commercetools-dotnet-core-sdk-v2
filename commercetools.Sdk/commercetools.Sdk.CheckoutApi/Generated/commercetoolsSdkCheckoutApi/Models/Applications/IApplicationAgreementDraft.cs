using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationAgreementDraft))]
    public partial interface IApplicationAgreementDraft
    {
        string Name { get; set; }

        IApplicationAgreementType Type { get; set; }

        IApplicationAgreementStatus Status { get; set; }

        ILocalizedString Text { get; set; }

    }
}
