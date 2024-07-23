namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetLocaleAction : ICustomerSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public CustomerSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
