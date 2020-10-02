using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeTaxCalculationMode")]
    public partial class CartChangeTaxCalculationModeAction : CartUpdateAction
    {
        public string TaxCalculationMode { get; set;}
        
        [JsonIgnore]
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
        public CartChangeTaxCalculationModeAction()
        { 
           this.Action = "changeTaxCalculationMode";
        }
    }
}
