using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Attribute))]
    public partial interface IAttribute
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
