using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderUpdateItemShippingAddressAction : IOrderUpdateItemShippingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public OrderUpdateItemShippingAddressAction()
        { 
           this.Action = "updateItemShippingAddress";
        }
    }
}
