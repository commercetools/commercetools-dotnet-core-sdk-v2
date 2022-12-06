using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TimeSetAttribute))]
    public partial interface ITimeSetAttribute : IAttribute
    {
        IList<TimeSpan> Value { get; set; }
        IEnumerable<TimeSpan> ValueEnumerable { set => Value = value.ToList(); }


    }
}
