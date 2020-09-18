using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCartTotalTax")]
    public class CartSetCartTotalTaxAction : CartUpdateAction
    {
        public Money ExternalTotalGross { get; set;}
        
        public List<TaxPortionDraft> ExternalTaxPortions { get; set;}
    }
}
