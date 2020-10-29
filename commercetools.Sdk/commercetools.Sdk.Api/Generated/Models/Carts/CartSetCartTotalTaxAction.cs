using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetCartTotalTaxAction : ICartSetCartTotalTaxAction
    {
        public string Action { get; set;}
        
        public IMoney ExternalTotalGross { get; set;}
        
        public List<ITaxPortionDraft> ExternalTaxPortions { get; set;}
        public CartSetCartTotalTaxAction()
        { 
           this.Action = "setCartTotalTax";
        }
    }
}
