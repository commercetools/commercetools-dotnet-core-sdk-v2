using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.DateTimeSetAttribute))]
    public partial interface IDateTimeSetAttribute : IAttribute
    {
        List<DateTime> Value { get; set; }
    }
}
