namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetCustomerEmailAction : IOrderSetCustomerEmailAction
    {
        public string Action { get; set; }

        public string Email { get; set; }
        public OrderSetCustomerEmailAction()
        {
            this.Action = "setCustomerEmail";
        }
    }
}
