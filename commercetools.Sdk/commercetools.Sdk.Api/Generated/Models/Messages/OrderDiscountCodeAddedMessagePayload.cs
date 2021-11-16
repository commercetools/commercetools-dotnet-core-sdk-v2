using commercetools.Api.Models.DiscountCodes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderDiscountCodeAddedMessagePayload : IOrderDiscountCodeAddedMessagePayload
    {
        public string Type { get; set;}
        
        public IDiscountCodeReference DiscountCode { get; set;}
        public OrderDiscountCodeAddedMessagePayload()
        { 
           this.Type = "OrderDiscountCodeAdded";
        }
    }
}
