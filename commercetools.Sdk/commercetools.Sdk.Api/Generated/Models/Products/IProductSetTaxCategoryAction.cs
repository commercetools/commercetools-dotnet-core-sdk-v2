using commercetools.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetTaxCategoryAction))]
    public partial interface IProductSetTaxCategoryAction : IProductUpdateAction
    {
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
    }
}
