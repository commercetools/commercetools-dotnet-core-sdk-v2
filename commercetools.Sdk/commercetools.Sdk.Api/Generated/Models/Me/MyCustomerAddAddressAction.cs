using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerAddAddressAction : IMyCustomerAddAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public MyCustomerAddAddressAction()
        {
            this.Action = "addAddress";
        }
    }
}
