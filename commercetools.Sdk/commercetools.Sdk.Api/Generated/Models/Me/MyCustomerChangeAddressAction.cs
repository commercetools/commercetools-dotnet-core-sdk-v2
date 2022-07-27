using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerChangeAddressAction : IMyCustomerChangeAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }

        public IBaseAddress Address { get; set; }
        public MyCustomerChangeAddressAction()
        {
            this.Action = "changeAddress";
        }
    }
}
