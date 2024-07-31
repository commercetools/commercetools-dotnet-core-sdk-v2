using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction))]
    public partial interface IProductTailoringSetMetaDescriptionAction : IProductTailoringUpdateAction
    {
        ILocalizedString MetaDescription { get; set; }

        bool? Staged { get; set; }

    }
}
