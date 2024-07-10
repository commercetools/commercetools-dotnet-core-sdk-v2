namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringMoveImageToPositionAction : IProductTailoringMoveImageToPositionAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string ImageUrl { get; set; }

        public long Position { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringMoveImageToPositionAction()
        {
            this.Action = "moveImageToPosition";
        }
    }
}
