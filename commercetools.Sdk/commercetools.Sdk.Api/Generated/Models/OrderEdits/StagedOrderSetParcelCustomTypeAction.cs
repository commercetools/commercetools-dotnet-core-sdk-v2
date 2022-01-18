using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetParcelCustomTypeAction : IStagedOrderSetParcelCustomTypeAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public Object Fields { get; set; }
        public StagedOrderSetParcelCustomTypeAction()
        {
            this.Action = "setParcelCustomType";
        }
    }
}
