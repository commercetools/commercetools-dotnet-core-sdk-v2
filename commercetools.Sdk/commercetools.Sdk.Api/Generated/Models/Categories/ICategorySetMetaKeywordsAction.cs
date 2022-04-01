using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetMetaKeywordsAction))]
    public partial interface ICategorySetMetaKeywordsAction : ICategoryUpdateAction
    {
        ILocalizedString MetaKeywords { get; set; }
    }
}
