using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("Classification")]
    public partial class ClassificationShippingRateInput : ShippingRateInput
    {
        public string Key { get; set;}
        
        public LocalizedString Label { get; set;}
        public ClassificationShippingRateInput()
        { 
           this.Type = "Classification";
        }
    }
}
