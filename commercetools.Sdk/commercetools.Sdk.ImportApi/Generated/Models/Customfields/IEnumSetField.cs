using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.EnumSetField))]
    public partial interface IEnumSetField : ICustomField
    {
        List<string> Value { get; set;}
    }
}
