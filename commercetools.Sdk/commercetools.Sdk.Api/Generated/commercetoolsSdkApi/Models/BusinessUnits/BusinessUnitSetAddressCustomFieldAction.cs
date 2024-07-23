using System;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetAddressCustomFieldAction : IBusinessUnitSetAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public BusinessUnitSetAddressCustomFieldAction()
        {
            this.Action = "setAddressCustomField";
        }
    }
}
