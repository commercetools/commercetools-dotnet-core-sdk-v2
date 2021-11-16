using commercetools.Api.Models.CustomerGroups;


namespace commercetools.Api.Models.Customers
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
