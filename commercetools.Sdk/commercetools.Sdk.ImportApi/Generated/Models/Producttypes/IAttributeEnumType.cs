using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeEnumType))]
    public partial interface IAttributeEnumType : IAttributeType
    {
        List<IAttributePlainEnumValue> Values { get; set; }
    }
}
