using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCountry")]
    public class StagedOrderSetCountryAction : StagedOrderUpdateAction
    {
        public string Country { get; set;}
    }
}
