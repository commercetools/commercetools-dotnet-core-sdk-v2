using commercetools.Api.Generated.Models.Projects;
using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Projects
{
    public interface ICartClassificationType : IShippingRateInputType
    {
        List<ICustomFieldLocalizedEnumValue> Values { get; set;}
    }
}
