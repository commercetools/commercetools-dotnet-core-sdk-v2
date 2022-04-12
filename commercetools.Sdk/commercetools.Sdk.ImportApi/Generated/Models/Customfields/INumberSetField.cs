using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.NumberSetField))]
    public partial interface INumberSetField : ICustomField
    {
        List<decimal> Value { get; set; }
    }
}
