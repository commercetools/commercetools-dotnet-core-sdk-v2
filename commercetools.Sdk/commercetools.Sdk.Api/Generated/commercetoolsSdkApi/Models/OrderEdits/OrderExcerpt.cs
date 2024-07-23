using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderExcerpt : IOrderExcerpt
    {
        public ITypedMoney TotalPrice { get; set; }

        public ITaxedPrice TaxedPrice { get; set; }

        public long Version { get; set; }
    }
}
