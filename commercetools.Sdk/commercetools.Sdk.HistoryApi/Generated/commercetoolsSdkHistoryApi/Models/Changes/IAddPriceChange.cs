using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPriceChange))]
    public partial interface IAddPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IPrice NextValue { get; set; }

        string CatalogData { get; set; }

        string PriceId { get; set; }

    }
}
