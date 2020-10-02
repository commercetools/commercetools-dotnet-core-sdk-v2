using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setLocale")]
    public partial class OrderSetLocaleAction : OrderUpdateAction
    {
        public string Locale { get; set;}
        public OrderSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}
