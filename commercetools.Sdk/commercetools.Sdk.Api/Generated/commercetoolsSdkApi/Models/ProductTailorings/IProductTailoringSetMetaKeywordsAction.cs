using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction))]
    public partial interface IProductTailoringSetMetaKeywordsAction : IProductTailoringUpdateAction
    {
        ILocalizedString MetaKeywords { get; set; }

        bool? Staged { get; set; }

    }
}
