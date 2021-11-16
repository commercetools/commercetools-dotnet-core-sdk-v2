using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueFixedDraft : ICartDiscountValueFixedDraft
    {
        public string Type { get; set; }

        public List<IMoney> Money { get; set; }
        public CartDiscountValueFixedDraft()
        {
            this.Type = "fixed";
        }
    }
}
