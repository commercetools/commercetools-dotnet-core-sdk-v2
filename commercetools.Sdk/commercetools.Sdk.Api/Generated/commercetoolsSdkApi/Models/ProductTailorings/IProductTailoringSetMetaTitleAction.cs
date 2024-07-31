using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction))]
    public partial interface IProductTailoringSetMetaTitleAction : IProductTailoringUpdateAction
    {
        ILocalizedString MetaTitle { get; set; }

        bool? Staged { get; set; }

    }
}
