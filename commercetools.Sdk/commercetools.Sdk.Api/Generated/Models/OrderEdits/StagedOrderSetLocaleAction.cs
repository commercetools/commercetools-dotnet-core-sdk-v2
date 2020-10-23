using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderSetLocaleAction : IStagedOrderSetLocaleAction
    {
        public string Action { get; set;}
        
        public string Locale { get; set;}
        public StagedOrderSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}
