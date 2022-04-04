using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountUpdate : ICartDiscountUpdate
    {
        public long Version { get; set; }

        public List<ICartDiscountUpdateAction> Actions { get; set; }
    }
}
