using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetReturnItemCustomTypeAction : IStagedOrderSetReturnItemCustomTypeAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public Object Fields { get; set; }
        public StagedOrderSetReturnItemCustomTypeAction()
        {
            this.Action = "setReturnItemCustomType";
        }
    }
}
