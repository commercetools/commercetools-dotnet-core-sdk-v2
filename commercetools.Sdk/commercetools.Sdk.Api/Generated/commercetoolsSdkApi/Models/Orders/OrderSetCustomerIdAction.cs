

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetCustomerIdAction : IOrderSetCustomerIdAction
    {
        public string Action { get; set; }

        public string CustomerId { get; set; }
        public OrderSetCustomerIdAction()
        {
            this.Action = "setCustomerId";
        }
    }
}
