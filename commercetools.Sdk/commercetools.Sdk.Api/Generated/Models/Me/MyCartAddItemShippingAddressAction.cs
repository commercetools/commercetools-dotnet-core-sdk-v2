using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartAddItemShippingAddressAction : IMyCartAddItemShippingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public MyCartAddItemShippingAddressAction()
        {
            this.Action = "addItemShippingAddress";
        }
    }
}
