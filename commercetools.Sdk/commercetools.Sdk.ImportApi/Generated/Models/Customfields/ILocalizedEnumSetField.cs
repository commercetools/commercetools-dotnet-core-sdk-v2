using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    public partial interface ILocalizedEnumSetField : ICustomField
    {
        List<string> Value { get; set; }
    }
}
