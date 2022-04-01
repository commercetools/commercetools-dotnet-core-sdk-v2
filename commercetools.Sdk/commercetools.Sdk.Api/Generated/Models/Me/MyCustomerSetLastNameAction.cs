namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCustomerSetLastNameAction : IMyCustomerSetLastNameAction
    {
        public string Action { get; set; }

        public string LastName { get; set; }
        public MyCustomerSetLastNameAction()
        {
            this.Action = "setLastName";
        }
    }
}
