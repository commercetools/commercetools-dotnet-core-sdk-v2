using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCartTotalTaxAction : ICartSetCartTotalTaxAction
    {
        public string Action { get; set; }

        public IMoney ExternalTotalGross { get; set; }

        public IList<ITaxPortionDraft> ExternalTaxPortions { get; set; }
        public IEnumerable<ITaxPortionDraft> ExternalTaxPortionsEnumerable { set => ExternalTaxPortions = value.ToList(); }

        public CartSetCartTotalTaxAction()
        {
            this.Action = "setCartTotalTax";
        }
    }
}
