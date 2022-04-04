using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerAddStoreAction : ICustomerAddStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CustomerAddStoreAction()
        {
            this.Action = "addStore";
        }
    }
}
