using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountValueAbsolute : IProductDiscountValueAbsolute
    {
        public string Type { get; set; }

        public IList<ICentPrecisionMoney> Money { get; set; }

        public IEnumerable<ICentPrecisionMoney> MoneyEnumerable { set => Money = value.ToList(); }
        public ProductDiscountValueAbsolute()
        {
            this.Type = "absolute";
        }
    }
}
