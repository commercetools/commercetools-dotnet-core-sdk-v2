using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetOrderTotalTaxAction : IStagedOrderSetOrderTotalTaxAction
    {
        public string Action { get; set; }

        public IMoney ExternalTotalGross { get; set; }

        public IList<ITaxPortionDraft> ExternalTaxPortions { get; set; }
        public IEnumerable<ITaxPortionDraft> ExternalTaxPortionsEnumerable { set => ExternalTaxPortions = value.ToList(); }

        public StagedOrderSetOrderTotalTaxAction()
        {
            this.Action = "setOrderTotalTax";
        }
    }
}
