using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeEnumType))]
    public partial interface IAttributeEnumType : IAttributeType
    {
        List<IAttributePlainEnumValue> Values { get; set; }

    }
}
