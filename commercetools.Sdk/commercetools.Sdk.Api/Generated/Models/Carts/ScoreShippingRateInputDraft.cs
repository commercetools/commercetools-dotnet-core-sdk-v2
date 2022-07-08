namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ScoreShippingRateInputDraft : IScoreShippingRateInputDraft
    {
        public string Type { get; set; }

        public long Score { get; set; }
        public ScoreShippingRateInputDraft()
        {
            this.Type = "Score";
        }
    }
}
