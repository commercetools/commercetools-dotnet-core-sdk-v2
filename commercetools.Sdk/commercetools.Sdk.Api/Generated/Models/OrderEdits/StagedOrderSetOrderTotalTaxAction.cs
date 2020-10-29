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
    public partial class StagedOrderSetOrderTotalTaxAction : IStagedOrderSetOrderTotalTaxAction
    {
        public string Action { get; set;}
        
        public IMoney ExternalTotalGross { get; set;}
        
        public List<ITaxPortionDraft> ExternalTaxPortions { get; set;}
        public StagedOrderSetOrderTotalTaxAction()
        { 
           this.Action = "setOrderTotalTax";
        }
    }
}
