using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateTimeField))]
    public partial interface IDateTimeField : ICustomField
    {
        DateTime Value { get; set; }

    }
}
