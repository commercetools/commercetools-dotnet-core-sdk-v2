using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.TimeSetAttribute))]
    public partial interface ITimeSetAttribute : IAttribute
    {
        List<TimeSpan> Value { get; set;}
    }
}
