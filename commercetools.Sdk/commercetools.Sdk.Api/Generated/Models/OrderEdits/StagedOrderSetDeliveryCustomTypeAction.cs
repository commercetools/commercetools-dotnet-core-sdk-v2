using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetDeliveryCustomTypeAction : IStagedOrderSetDeliveryCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public Object Fields { get; set; }
        public StagedOrderSetDeliveryCustomTypeAction()
        {
            this.Action = "setDeliveryCustomType";
        }
    }
}
