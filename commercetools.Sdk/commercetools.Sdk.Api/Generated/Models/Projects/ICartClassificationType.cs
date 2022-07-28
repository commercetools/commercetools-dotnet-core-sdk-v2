using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.CartClassificationType))]
    public partial interface ICartClassificationType : IShippingRateInputType
    {
        List<ICustomFieldLocalizedEnumValue> Values { get; set; }

    }
}
