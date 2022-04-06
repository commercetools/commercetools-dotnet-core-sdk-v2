using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateTimeField))]
    public partial interface IDateTimeField : ICustomField
    {
        DateTime Value { get; set; }
    }
}
