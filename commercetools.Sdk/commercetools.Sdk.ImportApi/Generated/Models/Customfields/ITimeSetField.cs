using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.TimeSetField))]
    public partial interface ITimeSetField : ICustomField
    {
        List<TimeSpan> Value { get; set;}
    }
}
