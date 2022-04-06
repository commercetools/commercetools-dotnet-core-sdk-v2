using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateTimeSetField))]
    public partial interface IDateTimeSetField : ICustomField
    {
        List<DateTime> Value { get; set; }
    }
}
