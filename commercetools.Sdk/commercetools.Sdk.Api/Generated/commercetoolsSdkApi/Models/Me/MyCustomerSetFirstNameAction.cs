

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetFirstNameAction : IMyCustomerSetFirstNameAction
    {
        public string Action { get; set; }

        public string FirstName { get; set; }
        public MyCustomerSetFirstNameAction()
        {
            this.Action = "setFirstName";
        }
    }
}
