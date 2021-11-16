using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerAddAddressAction : ICustomerAddAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public CustomerAddAddressAction()
        {
            this.Action = "addAddress";
        }
    }
}
