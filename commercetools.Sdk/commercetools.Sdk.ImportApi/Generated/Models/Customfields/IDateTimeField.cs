using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.DateTimeField))]
    public partial interface IDateTimeField : ICustomField
    {
        DateTime Value { get; set;}
    }
}
