namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCustomerSetLocaleAction : IMyCustomerSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public MyCustomerSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
