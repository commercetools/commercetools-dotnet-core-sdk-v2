namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategorySetDescriptionAction : ITaxCategorySetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public TaxCategorySetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
