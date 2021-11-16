namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategoryRemoveTaxRateAction : ITaxCategoryRemoveTaxRateAction
    {
        public string Action { get; set;}
        
        public string TaxRateId { get; set;}
        public TaxCategoryRemoveTaxRateAction()
        { 
           this.Action = "removeTaxRate";
        }
    }
}
