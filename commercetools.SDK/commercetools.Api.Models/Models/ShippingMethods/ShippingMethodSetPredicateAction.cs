using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("setPredicate")]
    public partial class ShippingMethodSetPredicateAction : ShippingMethodUpdateAction
    {
        public string Predicate { get; set;}
        public ShippingMethodSetPredicateAction()
        { 
           this.Action = "setPredicate";
        }
    }
}
