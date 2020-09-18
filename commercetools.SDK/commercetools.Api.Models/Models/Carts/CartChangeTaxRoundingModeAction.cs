using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeTaxRoundingMode")]
    public class CartChangeTaxRoundingModeAction : CartUpdateAction
    {
        public string TaxRoundingMode { get; set;}
        
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
    }
}
