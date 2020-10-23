using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartChangeTaxRoundingModeAction : ICartChangeTaxRoundingModeAction
    {
        public string Action { get; set;}
        
        public string TaxRoundingMode { get; set;}
        
        [JsonIgnore]
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        public CartChangeTaxRoundingModeAction()
        { 
           this.Action = "changeTaxRoundingMode";
        }
    }
}
