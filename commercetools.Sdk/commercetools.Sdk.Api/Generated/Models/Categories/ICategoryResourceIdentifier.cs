using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryResourceIdentifier))]
    public partial interface ICategoryResourceIdentifier : IResourceIdentifier
    {
    }
}
