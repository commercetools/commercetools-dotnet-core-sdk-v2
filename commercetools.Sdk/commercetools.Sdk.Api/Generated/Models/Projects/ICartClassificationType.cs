using commercetools.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.CartClassificationType))]
    public partial interface ICartClassificationType : IShippingRateInputType
    {
        List<ICustomFieldLocalizedEnumValue> Values { get; set; }
    }
}
