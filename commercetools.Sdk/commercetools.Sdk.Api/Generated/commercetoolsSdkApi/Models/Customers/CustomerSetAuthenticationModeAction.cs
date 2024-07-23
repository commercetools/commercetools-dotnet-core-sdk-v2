namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetAuthenticationModeAction : ICustomerSetAuthenticationModeAction
    {
        public string Action { get; set; }

        public IAuthenticationMode AuthMode { get; set; }

        public string Password { get; set; }
        public CustomerSetAuthenticationModeAction()
        {
            this.Action = "setAuthenticationMode";
        }
    }
}
