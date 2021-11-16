namespace commercetools.Api.Models.Products
{
    public partial class ProductSetKeyAction : IProductSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ProductSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
