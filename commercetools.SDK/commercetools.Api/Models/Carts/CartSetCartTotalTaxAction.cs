using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCartTotalTax")]
    public partial class CartSetCartTotalTaxAction : CartUpdateAction
    {
        public Money ExternalTotalGross { get; set;}
        
        public List<TaxPortionDraft> ExternalTaxPortions { get; set;}
        public CartSetCartTotalTaxAction()
        { 
           this.Action = "setCartTotalTax";
        }
    }
}
