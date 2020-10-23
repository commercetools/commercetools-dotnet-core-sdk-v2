using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartChangeTaxCalculationModeAction : ICartChangeTaxCalculationModeAction
    {
        public string Action { get; set;}
        
        public string TaxCalculationMode { get; set;}
        
        [JsonIgnore]
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
        public CartChangeTaxCalculationModeAction()
        { 
           this.Action = "changeTaxCalculationMode";
        }
    }
}
