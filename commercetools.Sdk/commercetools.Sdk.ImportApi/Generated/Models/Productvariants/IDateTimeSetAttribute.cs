using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeSetAttribute))]
    public partial interface IDateTimeSetAttribute : IAttribute
    {
        IList<DateTime> Value { get; set; }
        IEnumerable<DateTime> ValueEnumerable { set => Value = value.ToList(); }


    }
}
