using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.DateField))]
    public partial interface IDateField : ICustomField
    {
        DateTime Value { get; set; }
    }
}
