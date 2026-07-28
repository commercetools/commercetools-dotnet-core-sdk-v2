

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantMoveImageToPositionAction : IVariantMoveImageToPositionAction
    {
        public string Action { get; set; }

        public string ImageUrl { get; set; }

        public long Position { get; set; }

        public bool? Staged { get; set; }
        public VariantMoveImageToPositionAction()
        {
            this.Action = "moveImageToPosition";
        }
    }
}
