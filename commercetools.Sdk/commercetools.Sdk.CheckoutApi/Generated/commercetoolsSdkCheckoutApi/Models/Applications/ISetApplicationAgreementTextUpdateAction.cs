using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTextUpdateAction))]
    public partial interface ISetApplicationAgreementTextUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string AgreementId { get; set; }

        ILocalizedString Text { get; set; }

    }
}
