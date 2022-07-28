using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizedEnumType))]
    public partial interface IAttributeLocalizedEnumType : IAttributeType
    {
        List<IAttributeLocalizedEnumValue> Values { get; set; }

    }
}
