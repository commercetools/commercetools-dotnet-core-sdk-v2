using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.StringSetField))]
    public partial interface IStringSetField : ICustomField
    {
        List<string> Value { get; set;}
    }
}
