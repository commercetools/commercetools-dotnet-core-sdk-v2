using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateTimeSetField))]
    public partial interface IDateTimeSetField : ICustomField
    {
        IList<DateTime> Value { get; set; }
        IEnumerable<DateTime> ValueEnumerable { set => Value = value.ToList(); }


    }
}
