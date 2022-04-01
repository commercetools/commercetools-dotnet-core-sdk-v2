namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public partial class TaxCategoryReplaceTaxRateAction : ITaxCategoryReplaceTaxRateAction
    {
        public string Action { get; set; }

        public string TaxRateId { get; set; }

        public ITaxRateDraft TaxRate { get; set; }
        public TaxCategoryReplaceTaxRateAction()
        {
            this.Action = "replaceTaxRate";
        }
    }
}
