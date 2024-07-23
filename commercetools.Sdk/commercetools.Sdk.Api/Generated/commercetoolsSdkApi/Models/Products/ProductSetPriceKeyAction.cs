namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetPriceKeyAction : IProductSetPriceKeyAction
    {
        public string Action { get; set; }

        public string PriceId { get; set; }

        public bool? Staged { get; set; }

        public string Key { get; set; }
        public ProductSetPriceKeyAction()
        {
            this.Action = "setPriceKey";
        }
    }
}
