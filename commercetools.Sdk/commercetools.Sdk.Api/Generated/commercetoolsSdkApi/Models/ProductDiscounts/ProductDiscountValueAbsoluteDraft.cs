using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountValueAbsoluteDraft : IProductDiscountValueAbsoluteDraft
    {
        public string Type { get; set; }

        public IList<IMoney> Money { get; set; }
        public IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }

        public ProductDiscountValueAbsoluteDraft()
        {
            this.Type = "absolute";
        }
    }
}
