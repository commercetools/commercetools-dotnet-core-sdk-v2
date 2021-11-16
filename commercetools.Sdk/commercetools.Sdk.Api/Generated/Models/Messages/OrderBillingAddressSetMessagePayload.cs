using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderBillingAddressSetMessagePayload : IOrderBillingAddressSetMessagePayload
    {
        public string Type { get; set;}
        
        public IAddress Address { get; set;}
        
        public IAddress OldAddress { get; set;}
        public OrderBillingAddressSetMessagePayload()
        { 
           this.Type = "OrderBillingAddressSet";
        }
    }
}
