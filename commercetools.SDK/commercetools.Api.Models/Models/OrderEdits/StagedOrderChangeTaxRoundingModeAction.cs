using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeTaxRoundingMode")]
    public partial class StagedOrderChangeTaxRoundingModeAction : StagedOrderUpdateAction
    {
        public string TaxRoundingMode { get; set;}
        
        [JsonIgnore]
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        public StagedOrderChangeTaxRoundingModeAction()
        { 
           this.Action = "changeTaxRoundingMode";
        }
    }
}
