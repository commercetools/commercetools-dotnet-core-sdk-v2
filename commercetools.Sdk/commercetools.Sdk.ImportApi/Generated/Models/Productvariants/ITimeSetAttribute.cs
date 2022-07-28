using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TimeSetAttribute))]
    public partial interface ITimeSetAttribute : IAttribute
    {
        List<TimeSpan> Value { get; set; }

    }
}
