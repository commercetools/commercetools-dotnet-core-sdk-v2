using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeSlugAction))]
    public partial interface ICategoryChangeSlugAction : ICategoryUpdateAction
    {
        ILocalizedString Slug { get; set; }

    }
}
