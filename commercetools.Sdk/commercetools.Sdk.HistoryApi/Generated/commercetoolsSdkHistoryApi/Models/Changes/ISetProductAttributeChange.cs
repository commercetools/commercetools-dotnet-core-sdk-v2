using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductAttributeChange))]
    public partial interface ISetProductAttributeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string CatalogData { get; set; }

        IAttribute PreviousValue { get; set; }

        IAttribute NextValue { get; set; }

    }
}
