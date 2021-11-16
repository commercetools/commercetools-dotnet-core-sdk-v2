using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.TimeField))]
    public partial interface ITimeField : ICustomField
    {
        TimeSpan Value { get; set;}
    }
}
