using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetCustomerGroupAction : ICustomerSetCustomerGroupAction
    {
        public string Action { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
        public CustomerSetCustomerGroupAction()
        {
            this.Action = "setCustomerGroup";
        }
    }
}
