using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Projects
{
    public class CartClassificationType : ShippingRateInputType
    {
        public List<CustomFieldLocalizedEnumValue> Values { get; set;}
    }
}
