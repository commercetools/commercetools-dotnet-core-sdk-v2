namespace commercetools.HistoryApi.Models.Labels
{
    public partial class CustomObjectLabel : ICustomObjectLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Container { get; set; }
        public CustomObjectLabel()
        {
            this.Type = "CustomObjectLabel";
        }
    }
}
