using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    public partial interface ILocalizedEnumSetField : ICustomField
    {
        List<string> Value { get; set;}
    }
}
