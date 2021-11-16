using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.BooleanSetField))]
    public partial interface IBooleanSetField : ICustomField
    {
        List<bool> Value { get; set;}
    }
}
