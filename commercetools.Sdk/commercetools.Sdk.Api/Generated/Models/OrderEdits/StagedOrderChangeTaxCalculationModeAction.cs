using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderChangeTaxCalculationModeAction : IStagedOrderChangeTaxCalculationModeAction
    {
        public string Action { get; set;}
        
        public string TaxCalculationMode { get; set;}
        
        [JsonIgnore]
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
        public StagedOrderChangeTaxCalculationModeAction()
        { 
           this.Action = "changeTaxCalculationMode";
        }
    }
}
