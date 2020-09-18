using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setOrderTotalTax")]
    public class StagedOrderSetOrderTotalTaxAction : StagedOrderUpdateAction
    {
        public Money ExternalTotalGross { get; set;}
        
        public List<TaxPortionDraft> ExternalTaxPortions { get; set;}
    }
}
