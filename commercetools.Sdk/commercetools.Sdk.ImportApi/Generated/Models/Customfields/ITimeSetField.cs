using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.TimeSetField))]
    public partial interface ITimeSetField : ICustomField
    {
        IList<TimeSpan> Value { get; set; }
        IEnumerable<TimeSpan> ValueEnumerable { set => Value = value.ToList(); }


    }
}
