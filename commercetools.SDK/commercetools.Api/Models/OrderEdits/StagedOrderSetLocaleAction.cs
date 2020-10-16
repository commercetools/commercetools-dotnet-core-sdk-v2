using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLocale")]
    public partial class StagedOrderSetLocaleAction : StagedOrderUpdateAction
    {
        public string Locale { get; set;}
        public StagedOrderSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}
