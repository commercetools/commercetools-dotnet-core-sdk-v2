

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class MergeCartDraft : IMergeCartDraft
    {
        public ICartResourceIdentifier AnonymousCart { get; set; }

        public ICartMergeMode MergeMode { get; set; }

        public bool? UpdateProductData { get; set; }

        public string AnonymousId { get; set; }
    }
}
