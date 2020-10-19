using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCountry")]
    public partial class StagedOrderSetCountryAction : StagedOrderUpdateAction
    {
        public string Country { get; set;}
        public StagedOrderSetCountryAction()
        { 
           this.Action = "setCountry";
        }
    }
}
