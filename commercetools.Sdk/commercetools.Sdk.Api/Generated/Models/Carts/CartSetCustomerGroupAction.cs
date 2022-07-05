using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomerGroupAction : ICartSetCustomerGroupAction
    {
        public string Action { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
        public CartSetCustomerGroupAction()
        {
            this.Action = "setCustomerGroup";
        }
    }
}
