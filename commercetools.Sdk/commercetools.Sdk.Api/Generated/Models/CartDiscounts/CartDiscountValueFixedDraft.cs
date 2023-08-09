using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueFixedDraft : ICartDiscountValueFixedDraft
    {
        public string Type { get; set; }

        public IList<ITypedMoneyDraft> Money { get; set; }
        public IEnumerable<ITypedMoneyDraft> MoneyEnumerable { set => Money = value.ToList(); }

        public CartDiscountValueFixedDraft()
        {
            this.Type = "fixed";
        }
    }
}
