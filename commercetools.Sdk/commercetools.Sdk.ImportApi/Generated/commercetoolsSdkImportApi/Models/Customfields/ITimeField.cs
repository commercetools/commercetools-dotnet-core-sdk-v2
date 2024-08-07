using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.TimeField))]
    public partial interface ITimeField : ICustomField
    {
        TimeSpan Value { get; set; }

    }
}
