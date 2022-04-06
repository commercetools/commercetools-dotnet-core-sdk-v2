using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeSetAttribute))]
    public partial interface IDateTimeSetAttribute : IAttribute
    {
        List<DateTime> Value { get; set; }
    }
}
