using commercetools.Api.Models.TaxCategories;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetTaxCategoryAction : IProductSetTaxCategoryAction
    {
        public string Action { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }
        public ProductSetTaxCategoryAction()
        {
            this.Action = "setTaxCategory";
        }
    }
}
