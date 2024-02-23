namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetFirstNameAction : ICustomerSetFirstNameAction
    {
        public string Action { get; set; }

        public string FirstName { get; set; }
        public CustomerSetFirstNameAction()
        {
            this.Action = "setFirstName";
        }
    }
}
