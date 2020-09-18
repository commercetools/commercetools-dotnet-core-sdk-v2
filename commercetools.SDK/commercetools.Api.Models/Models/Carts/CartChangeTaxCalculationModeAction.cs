using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeTaxCalculationMode")]
    public class CartChangeTaxCalculationModeAction : CartUpdateAction
    {
        public string TaxCalculationMode { get; set;}
        
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
    }
}
