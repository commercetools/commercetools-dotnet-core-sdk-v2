

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductMoveImageToPositionAction : IProductMoveImageToPositionAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string ImageUrl { get; set; }

        public long Position { get; set; }

        public bool? Staged { get; set; }
        public ProductMoveImageToPositionAction()
        {
            this.Action = "moveImageToPosition";
        }
    }
}
