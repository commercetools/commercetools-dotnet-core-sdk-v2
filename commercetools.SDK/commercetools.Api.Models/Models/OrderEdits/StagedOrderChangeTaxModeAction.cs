using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeTaxMode")]
    public partial class StagedOrderChangeTaxModeAction : StagedOrderUpdateAction
    {
        public string TaxMode { get; set;}
        
        [JsonIgnore]
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        public StagedOrderChangeTaxModeAction()
        { 
           this.Action = "changeTaxMode";
        }
    }
}
