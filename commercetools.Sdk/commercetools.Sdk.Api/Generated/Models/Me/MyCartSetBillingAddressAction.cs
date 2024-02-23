using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetBillingAddressAction : IMyCartSetBillingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public MyCartSetBillingAddressAction()
        {
            this.Action = "setBillingAddress";
        }
    }
}
