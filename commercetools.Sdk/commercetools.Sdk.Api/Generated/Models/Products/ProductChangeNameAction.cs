using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Products
{
    public partial class ProductChangeNameAction : IProductChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }

        public bool? Staged { get; set; }
        public ProductChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
