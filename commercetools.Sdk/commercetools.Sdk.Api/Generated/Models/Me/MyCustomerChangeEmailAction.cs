namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerChangeEmailAction : IMyCustomerChangeEmailAction
    {
        public string Action { get; set; }

        public string Email { get; set; }
        public MyCustomerChangeEmailAction()
        {
            this.Action = "changeEmail";
        }
    }
}
