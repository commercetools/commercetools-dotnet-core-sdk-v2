using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCartTotalTaxAction : ICartSetCartTotalTaxAction
    {
        public string Action { get; set; }

        public IMoney ExternalTotalGross { get; set; }

        public List<ITaxPortionDraft> ExternalTaxPortions { get; set; }
        public CartSetCartTotalTaxAction()
        {
            this.Action = "setCartTotalTax";
        }
    }
}
