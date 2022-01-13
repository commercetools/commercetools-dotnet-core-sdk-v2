using commercetools.Api.Models.DiscountCodes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderDiscountCodeRemovedMessagePayload : IOrderDiscountCodeRemovedMessagePayload
    {
        public string Type { get; set; }

        public IDiscountCodeReference DiscountCode { get; set; }
        public OrderDiscountCodeRemovedMessagePayload()
        {
            this.Type = "OrderDiscountCodeRemoved";
        }
    }
}
