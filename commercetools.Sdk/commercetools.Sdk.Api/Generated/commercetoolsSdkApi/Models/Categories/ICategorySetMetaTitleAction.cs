using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetMetaTitleAction))]
    public partial interface ICategorySetMetaTitleAction : ICategoryUpdateAction
    {
        ILocalizedString MetaTitle { get; set; }

    }
}
