using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models
{
    public partial class ModifiedBy : IModifiedBy
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public IReference Customer { get; set; }

        public string AnonymousId { get; set; }

        public string ClientId { get; set; }

        public bool IsPlatformClient { get; set; }
    }
}
