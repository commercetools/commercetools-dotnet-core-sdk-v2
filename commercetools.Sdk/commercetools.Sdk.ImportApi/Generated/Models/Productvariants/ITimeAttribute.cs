using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TimeAttribute))]
    public partial interface ITimeAttribute : IAttribute
    {
        TimeSpan Value { get; set; }

    }
}
