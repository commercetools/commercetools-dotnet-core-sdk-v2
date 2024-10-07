

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetCustomerNumberAction : ICustomerSetCustomerNumberAction
    {
        public string Action { get; set; }

        public string CustomerNumber { get; set; }
        public CustomerSetCustomerNumberAction()
        {
            this.Action = "setCustomerNumber";
        }
    }
}
