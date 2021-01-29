using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    public partial interface ILocalizedEnumSetField : ICustomField
    {
        List<string> Value { get; set;}
    }
}
