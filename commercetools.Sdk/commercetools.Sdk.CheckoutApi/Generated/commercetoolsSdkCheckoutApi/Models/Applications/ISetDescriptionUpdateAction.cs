using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetDescriptionUpdateAction))]
    public partial interface ISetDescriptionUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        ILocalizedString Description { get; set; }

    }
}
