using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryResourceIdentifier))]
    public partial interface ITaxCategoryResourceIdentifier : IResourceIdentifier
    {
    }
}
