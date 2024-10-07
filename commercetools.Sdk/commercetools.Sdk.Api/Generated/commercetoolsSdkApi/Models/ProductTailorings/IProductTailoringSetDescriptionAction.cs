using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction))]
    public partial interface IProductTailoringSetDescriptionAction : IProductTailoringUpdateAction
    {
        ILocalizedString Description { get; set; }

        bool? Staged { get; set; }

    }
}
