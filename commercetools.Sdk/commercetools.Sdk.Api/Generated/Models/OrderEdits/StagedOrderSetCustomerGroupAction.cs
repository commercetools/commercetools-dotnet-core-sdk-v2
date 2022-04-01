using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomerGroupAction : IStagedOrderSetCustomerGroupAction
    {
        public string Action { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
        public StagedOrderSetCustomerGroupAction()
        {
            this.Action = "setCustomerGroup";
        }
    }
}
