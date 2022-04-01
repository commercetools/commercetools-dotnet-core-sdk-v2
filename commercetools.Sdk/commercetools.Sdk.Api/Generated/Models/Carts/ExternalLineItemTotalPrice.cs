using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class ExternalLineItemTotalPrice : IExternalLineItemTotalPrice
    {
        public IMoney Price { get; set; }

        public IMoney TotalPrice { get; set; }
    }
}
