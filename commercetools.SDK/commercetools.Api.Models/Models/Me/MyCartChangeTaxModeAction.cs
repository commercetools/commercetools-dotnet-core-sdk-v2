using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeTaxMode")]
    public class MyCartChangeTaxModeAction : MyCartUpdateAction
    {
        public string TaxMode { get; set;}
        
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
    }
}
