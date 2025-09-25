

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueRelativeDraft : ICartDiscountValueRelativeDraft
    {
        public string Type { get; set; }

        public long Permyriad { get; set; }

        public IDiscountApplicationMode ApplicationMode { get; set; }
        public CartDiscountValueRelativeDraft()
        {
            this.Type = "relative";
        }
    }
}
