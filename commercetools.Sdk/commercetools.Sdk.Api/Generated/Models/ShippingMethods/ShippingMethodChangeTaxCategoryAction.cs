using commercetools.Api.Models.TaxCategories;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodChangeTaxCategoryAction : IShippingMethodChangeTaxCategoryAction
    {
        public string Action { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }
        public ShippingMethodChangeTaxCategoryAction()
        {
            this.Action = "changeTaxCategory";
        }
    }
}
