using System.Collections.Generic;
using System.Linq;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.TimeSetField))]
    public partial interface ITimeSetField : ICustomField
    {
        IList<TimeSpan> Value { get; set; }

        IEnumerable<TimeSpan> ValueEnumerable { set => Value = value.ToList(); }

    }
}
