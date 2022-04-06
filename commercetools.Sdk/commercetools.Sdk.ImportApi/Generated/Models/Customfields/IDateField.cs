using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateField))]
    public partial interface IDateField : ICustomField
    {
        DateTime Value { get; set; }
    }
}
