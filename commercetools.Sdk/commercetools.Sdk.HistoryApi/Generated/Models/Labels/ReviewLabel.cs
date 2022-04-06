namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    public partial class ReviewLabel : IReviewLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Title { get; set; }
        public ReviewLabel()
        {
            this.Type = "ReviewLabel";
        }
    }
}
