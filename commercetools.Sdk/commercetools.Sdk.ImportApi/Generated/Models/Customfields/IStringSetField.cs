using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.StringSetField))]
    public partial interface IStringSetField : ICustomField
    {
        List<string> Value { get; set; }

    }
}
