using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePriceChange))]
    public partial interface IChangePriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CatalogData { get; set; }

        string PriceId { get; set; }

        IPrice PreviousValue { get; set; }

        IPrice NextValue { get; set; }

    }
}
