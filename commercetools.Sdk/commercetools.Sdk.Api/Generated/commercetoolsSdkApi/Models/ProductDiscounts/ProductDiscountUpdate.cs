using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountUpdate : IProductDiscountUpdate
    {
        public long Version { get; set; }

        public IList<IProductDiscountUpdateAction> Actions { get; set; }
        public IEnumerable<IProductDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
