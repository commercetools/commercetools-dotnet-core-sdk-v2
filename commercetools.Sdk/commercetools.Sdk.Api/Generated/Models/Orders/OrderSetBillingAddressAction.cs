using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetBillingAddressAction : IOrderSetBillingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public OrderSetBillingAddressAction()
        {
            this.Action = "setBillingAddress";
        }
    }
}
