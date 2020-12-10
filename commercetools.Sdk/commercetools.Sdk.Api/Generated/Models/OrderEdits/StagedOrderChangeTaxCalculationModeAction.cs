using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeTaxCalculationModeAction : IStagedOrderChangeTaxCalculationModeAction
    {
        public string Action { get; set;}
        
        public ITaxCalculationMode TaxCalculationMode { get; set;}
        public StagedOrderChangeTaxCalculationModeAction()
        { 
           this.Action = "changeTaxCalculationMode";
        }
    }
}
