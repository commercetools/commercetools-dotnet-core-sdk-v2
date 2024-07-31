

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetSalutationAction : ICustomerSetSalutationAction
    {
        public string Action { get; set; }

        public string Salutation { get; set; }
        public CustomerSetSalutationAction()
        {
            this.Action = "setSalutation";
        }
    }
}
