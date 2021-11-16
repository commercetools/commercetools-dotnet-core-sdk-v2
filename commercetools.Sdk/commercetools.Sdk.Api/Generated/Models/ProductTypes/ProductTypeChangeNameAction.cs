namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeNameAction : IProductTypeChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public ProductTypeChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
