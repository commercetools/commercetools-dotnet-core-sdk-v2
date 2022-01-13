using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryChangeSlugAction))]
    public partial interface ICategoryChangeSlugAction : ICategoryUpdateAction
    {
        ILocalizedString Slug { get; set; }
    }
}
