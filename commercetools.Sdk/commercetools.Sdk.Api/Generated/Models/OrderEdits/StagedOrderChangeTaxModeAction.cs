using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderChangeTaxModeAction : IStagedOrderChangeTaxModeAction
    {
        public string Action { get; set;}
        
        public string TaxMode { get; set;}
        
        [JsonIgnore]
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        public StagedOrderChangeTaxModeAction()
        { 
           this.Action = "changeTaxMode";
        }
    }
}
