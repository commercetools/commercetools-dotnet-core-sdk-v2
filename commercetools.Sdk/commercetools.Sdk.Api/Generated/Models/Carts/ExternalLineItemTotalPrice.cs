using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class ExternalLineItemTotalPrice : IExternalLineItemTotalPrice
    {
        public IMoney Price { get; set;}
        
        public IMoney TotalPrice { get; set;}
    }
}
