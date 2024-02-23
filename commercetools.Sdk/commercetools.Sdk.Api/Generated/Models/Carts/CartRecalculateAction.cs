namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartRecalculateAction : ICartRecalculateAction
    {
        public string Action { get; set; }

        public bool? UpdateProductData { get; set; }
        public CartRecalculateAction()
        {
            this.Action = "recalculate";
        }
    }
}
