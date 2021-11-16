namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeValueExternalChangeValue : IChangeValueExternalChangeValue
    {
        public string Type { get; set; }
        public ChangeValueExternalChangeValue()
        {
            this.Type = "external";
        }
    }
}
