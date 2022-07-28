using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoPriceChange))]
    public partial interface ISetShippingInfoPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IMoney NextValue { get; set; }

        IMoney PreviousValue { get; set; }

    }
}
