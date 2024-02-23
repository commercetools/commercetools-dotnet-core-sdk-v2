using System;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitSetAddressCustomFieldAction : IMyBusinessUnitSetAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyBusinessUnitSetAddressCustomFieldAction()
        {
            this.Action = "setAddressCustomField";
        }
    }
}
