using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.CartClassificationType))]
    public partial interface ICartClassificationType : IShippingRateInputType
    {
        List<ICustomFieldLocalizedEnumValue> Values { get; set; }
    }
}
