namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerSetCompanyNameAction : ICustomerSetCompanyNameAction
    {
        public string Action { get; set; }

        public string CompanyName { get; set; }
        public CustomerSetCompanyNameAction()
        {
            this.Action = "setCompanyName";
        }
    }
}
