using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueAbsoluteDraft : ICartDiscountValueAbsoluteDraft
    {
        public string Type { get; set; }

        public IList<IMoney> Money { get; set; }

        public IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }

        public IDiscountApplicationMode ApplicationMode { get; set; }
        public CartDiscountValueAbsoluteDraft()
        {
            this.Type = "absolute";
        }
    }
}
