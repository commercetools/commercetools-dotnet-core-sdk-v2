using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.NumberSetField))]
    public partial interface INumberSetField : ICustomField
    {
        List<double> Value { get; set;}
    }
}
