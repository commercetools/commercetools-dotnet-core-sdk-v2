using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderChangeTaxRoundingModeAction : IStagedOrderChangeTaxRoundingModeAction
    {
        public string Action { get; set;}
        
        public string TaxRoundingMode { get; set;}
        
        [JsonIgnore]
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        public StagedOrderChangeTaxRoundingModeAction()
        { 
           this.Action = "changeTaxRoundingMode";
        }
    }
}
