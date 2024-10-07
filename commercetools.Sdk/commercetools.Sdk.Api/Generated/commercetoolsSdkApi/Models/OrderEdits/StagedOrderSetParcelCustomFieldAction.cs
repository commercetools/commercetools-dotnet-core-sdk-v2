using System;

namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetParcelCustomFieldAction : IStagedOrderSetParcelCustomFieldAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public string ParcelKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetParcelCustomFieldAction()
        {
            this.Action = "setParcelCustomField";
        }
    }
}
