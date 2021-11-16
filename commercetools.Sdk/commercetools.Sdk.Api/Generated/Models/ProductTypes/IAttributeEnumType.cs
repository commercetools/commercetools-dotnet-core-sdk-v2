using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeEnumType))]
    public partial interface IAttributeEnumType : IAttributeType
    {
        List<IAttributePlainEnumValue> Values { get; set;}
    }
}
