using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{

    public partial class ModifiedBy : IModifiedBy
    {
        public bool IsPlatformClient { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }

        public string ClientId { get; set; }

        public string AnonymousId { get; set; }

        public IReference Customer { get; set; }

        public IReference Associate { get; set; }
    }
}
