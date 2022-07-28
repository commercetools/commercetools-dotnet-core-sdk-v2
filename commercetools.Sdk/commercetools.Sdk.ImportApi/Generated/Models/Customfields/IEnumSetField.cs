using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.EnumSetField))]
    public partial interface IEnumSetField : ICustomField
    {
        List<string> Value { get; set; }

    }
}
