using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitAddAddressAction : IMyBusinessUnitAddAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public MyBusinessUnitAddAddressAction()
        {
            this.Action = "addAddress";
        }
    }
}
