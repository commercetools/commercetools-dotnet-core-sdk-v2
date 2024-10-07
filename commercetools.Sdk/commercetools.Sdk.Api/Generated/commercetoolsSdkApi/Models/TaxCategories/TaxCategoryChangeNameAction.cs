

namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategoryChangeNameAction : ITaxCategoryChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public TaxCategoryChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
