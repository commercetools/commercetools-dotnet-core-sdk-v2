using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    public partial class LocalizedLabel : ILocalizedLabel
    {
        public string Type { get; set; }

        public ILocalizedString Value { get; set; }
        public LocalizedLabel()
        {
            this.Type = "LocalizedLabel";
        }
    }
}
