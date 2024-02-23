namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetCompanyNameAction : IMyCustomerSetCompanyNameAction
    {
        public string Action { get; set; }

        public string CompanyName { get; set; }
        public MyCustomerSetCompanyNameAction()
        {
            this.Action = "setCompanyName";
        }
    }
}
