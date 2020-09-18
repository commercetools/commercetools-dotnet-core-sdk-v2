using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeTaxMode")]
    public class CartChangeTaxModeAction : CartUpdateAction
    {
        public string TaxMode { get; set;}
        
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
    }
}
