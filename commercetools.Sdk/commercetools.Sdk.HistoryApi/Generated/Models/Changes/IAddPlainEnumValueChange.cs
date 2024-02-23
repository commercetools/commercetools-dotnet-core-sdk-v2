using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPlainEnumValueChange))]
    public partial interface IAddPlainEnumValueChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAttributePlainEnumValue NextValue { get; set; }

        string AttributeName { get; set; }

    }
}
