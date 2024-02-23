namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class TrackingData : ITrackingData
    {
        public string TrackingId { get; set; }

        public string Carrier { get; set; }

        public string Provider { get; set; }

        public string ProviderTransaction { get; set; }

        public bool IsReturn { get; set; }
    }
}
