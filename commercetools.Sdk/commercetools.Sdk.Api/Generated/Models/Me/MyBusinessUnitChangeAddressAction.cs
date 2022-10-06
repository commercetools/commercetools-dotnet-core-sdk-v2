using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitChangeAddressAction : IMyBusinessUnitChangeAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }

        public IBaseAddress Address { get; set; }
        public MyBusinessUnitChangeAddressAction()
        {
            this.Action = "changeAddress";
        }
    }
}
