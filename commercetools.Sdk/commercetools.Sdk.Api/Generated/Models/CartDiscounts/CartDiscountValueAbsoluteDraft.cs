using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueAbsoluteDraft : ICartDiscountValueAbsoluteDraft
    {
        public string Type { get; set; }

        public List<IMoney> Money { get; set; }
        public CartDiscountValueAbsoluteDraft()
        {
            this.Type = "absolute";
        }
    }
}
