namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerSetExternalIdAction : ICustomerSetExternalIdAction
    {
        public string Action { get; set; }

        public string ExternalId { get; set; }
        public CustomerSetExternalIdAction()
        {
            this.Action = "setExternalId";
        }
    }
}
