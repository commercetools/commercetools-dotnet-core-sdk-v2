namespace commercetools.HistoryApi.Models.Labels
{
    public partial class StringLabel : IStringLabel
    {
        public string Type { get; set; }

        public string Value { get; set; }
        public StringLabel()
        {
            this.Type = "StringLabel";
        }
    }
}
