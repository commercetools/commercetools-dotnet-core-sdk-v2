using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeTaxCalculationMode")]
    public class StagedOrderChangeTaxCalculationModeAction : StagedOrderUpdateAction
    {
        public string TaxCalculationMode { get; set;}
        
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
    }
}
