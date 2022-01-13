namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategorySetKeyAction : ITaxCategorySetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public TaxCategorySetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
