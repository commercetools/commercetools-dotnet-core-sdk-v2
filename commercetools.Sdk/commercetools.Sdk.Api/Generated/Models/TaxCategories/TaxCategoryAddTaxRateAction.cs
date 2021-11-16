namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategoryAddTaxRateAction : ITaxCategoryAddTaxRateAction
    {
        public string Action { get; set; }

        public ITaxRateDraft TaxRate { get; set; }
        public TaxCategoryAddTaxRateAction()
        {
            this.Action = "addTaxRate";
        }
    }
}
