

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeIsSearchableAction : IProductTypeChangeIsSearchableAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public bool IsSearchable { get; set; }
        public ProductTypeChangeIsSearchableAction()
        {
            this.Action = "changeIsSearchable";
        }
    }
}
