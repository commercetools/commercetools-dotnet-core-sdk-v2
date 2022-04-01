using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerChangeAddressAction : ICustomerChangeAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }

        public IBaseAddress Address { get; set; }
        public CustomerChangeAddressAction()
        {
            this.Action = "changeAddress";
        }
    }
}
