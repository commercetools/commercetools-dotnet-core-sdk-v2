

namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{

    public partial class Attribution : IAttribution
    {
        public string ClientId { get; set; }

        public IAttributionSource Source { get; set; }
    }
}
