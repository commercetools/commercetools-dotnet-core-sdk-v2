using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeTaxCalculationMode")]
    public partial class StagedOrderChangeTaxCalculationModeAction : StagedOrderUpdateAction
    {
        public string TaxCalculationMode { get; set;}
        
        [JsonIgnore]
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
        public StagedOrderChangeTaxCalculationModeAction()
        { 
           this.Action = "changeTaxCalculationMode";
        }
    }
}
