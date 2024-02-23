namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Asset : IAsset
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public ICustomFields Custom { get; set; }

        public string Key { get; set; }
    }
}
