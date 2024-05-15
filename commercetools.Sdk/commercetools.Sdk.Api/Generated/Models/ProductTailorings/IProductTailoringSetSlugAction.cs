using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction))]
    public partial interface IProductTailoringSetSlugAction : IProductTailoringUpdateAction
    {
        ILocalizedString Slug { get; set; }

        bool? Staged { get; set; }

    }
}
