using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartSetCartTotalTaxAction : CartUpdateAction
    {
        public Money ExternalTotalGross { get; set;}
        
        public List<TaxPortionDraft> ExternalTaxPortions { get; set;}
    }
}
