using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeTaxRoundingMode")]
    public partial class CartChangeTaxRoundingModeAction : CartUpdateAction
    {
        public string TaxRoundingMode { get; set;}
        
        [JsonIgnore]
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        public CartChangeTaxRoundingModeAction()
        { 
           this.Action = "changeTaxRoundingMode";
        }
    }
}
