using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction))]
    public partial interface IProductTailoringSetMetaAttributesAction : IProductTailoringUpdateAction
    {
        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        bool? Staged { get; set; }

    }
}
