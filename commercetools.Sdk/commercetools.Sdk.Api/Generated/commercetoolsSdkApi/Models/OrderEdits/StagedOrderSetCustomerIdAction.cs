namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetCustomerIdAction : IStagedOrderSetCustomerIdAction
    {
        public string Action { get; set; }

        public string CustomerId { get; set; }
        public StagedOrderSetCustomerIdAction()
        {
            this.Action = "setCustomerId";
        }
    }
}
