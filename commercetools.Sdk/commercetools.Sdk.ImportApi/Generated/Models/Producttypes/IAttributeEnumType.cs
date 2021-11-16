using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.AttributeEnumType))]
    public partial interface IAttributeEnumType : IAttributeType
    {
        List<IAttributePlainEnumValue> Values { get; set; }
    }
}
