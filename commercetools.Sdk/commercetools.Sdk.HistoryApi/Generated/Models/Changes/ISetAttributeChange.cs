using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAttributeChange))]
    public partial interface ISetAttributeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAttributeValue PreviousValue { get; set; }

        IAttributeValue NextValue { get; set; }

        string CatalogData { get; set; }

    }
}
