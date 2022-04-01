namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomerEmailAction : IStagedOrderSetCustomerEmailAction
    {
        public string Action { get; set; }

        public string Email { get; set; }
        public StagedOrderSetCustomerEmailAction()
        {
            this.Action = "setCustomerEmail";
        }
    }
}
