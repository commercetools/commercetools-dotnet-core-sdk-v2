using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderAddItemShippingAddressAction : IOrderAddItemShippingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public OrderAddItemShippingAddressAction()
        { 
           this.Action = "addItemShippingAddress";
        }
    }
}
