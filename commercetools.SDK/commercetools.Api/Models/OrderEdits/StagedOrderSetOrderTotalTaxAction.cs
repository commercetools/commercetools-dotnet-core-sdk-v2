using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setOrderTotalTax")]
    public partial class StagedOrderSetOrderTotalTaxAction : StagedOrderUpdateAction
    {
        public Money ExternalTotalGross { get; set;}
        
        public List<TaxPortionDraft> ExternalTaxPortions { get; set;}
        public StagedOrderSetOrderTotalTaxAction()
        { 
           this.Action = "setOrderTotalTax";
        }
    }
}
