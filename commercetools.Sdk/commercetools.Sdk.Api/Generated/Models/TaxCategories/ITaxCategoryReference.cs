using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryReference))]
    public partial interface ITaxCategoryReference : IReference
    {
        ITaxCategory Obj { get; set; }
    }
}
