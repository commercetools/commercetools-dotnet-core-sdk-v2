using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueAbsolute : ICartDiscountValueAbsolute
    {
        public string Type { get; set; }

        public IList<ICentPrecisionMoney> Money { get; set; }

        public IEnumerable<ICentPrecisionMoney> MoneyEnumerable { set => Money = value.ToList(); }

        public IDiscountApplicationMode ApplicationMode { get; set; }
        public CartDiscountValueAbsolute()
        {
            this.Type = "absolute";
        }
    }
}
