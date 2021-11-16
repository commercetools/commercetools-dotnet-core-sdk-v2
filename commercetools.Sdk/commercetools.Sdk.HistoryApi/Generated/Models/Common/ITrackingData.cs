using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.TrackingData))]
    public partial interface ITrackingData
    {
        string TrackingId { get; set; }

        string Carrier { get; set; }

        string Provider { get; set; }

        string ProviderTransaction { get; set; }

        bool IsReturn { get; set; }
    }
}
