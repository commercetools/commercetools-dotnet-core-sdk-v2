using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("CartClassification")]
    public class CartClassificationType : ShippingRateInputType
    {
        public List<CustomFieldLocalizedEnumValue> Values { get; set;}
    }
}
