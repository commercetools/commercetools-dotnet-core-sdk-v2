

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetMiddleNameAction : ICustomerSetMiddleNameAction
    {
        public string Action { get; set; }

        public string MiddleName { get; set; }
        public CustomerSetMiddleNameAction()
        {
            this.Action = "setMiddleName";
        }
    }
}
