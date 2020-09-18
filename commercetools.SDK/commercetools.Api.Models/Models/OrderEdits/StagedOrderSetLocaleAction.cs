using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLocale")]
    public class StagedOrderSetLocaleAction : StagedOrderUpdateAction
    {
        public string Locale { get; set;}
    }
}
