using System;

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetCustomFieldAction : IBusinessUnitSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public BusinessUnitSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
