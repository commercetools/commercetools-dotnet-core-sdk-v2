using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetOrderTotalTaxAction : IStagedOrderSetOrderTotalTaxAction
    {
        public string Action { get; set; }

        public IMoney ExternalTotalGross { get; set; }

        public List<ITaxPortionDraft> ExternalTaxPortions { get; set; }
        public StagedOrderSetOrderTotalTaxAction()
        {
            this.Action = "setOrderTotalTax";
        }
    }
}
