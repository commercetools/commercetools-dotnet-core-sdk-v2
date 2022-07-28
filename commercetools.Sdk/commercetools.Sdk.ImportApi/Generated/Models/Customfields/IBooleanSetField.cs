using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.BooleanSetField))]
    public partial interface IBooleanSetField : ICustomField
    {
        List<bool> Value { get; set; }

    }
}
