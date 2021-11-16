namespace commercetools.Api.Models.Carts
{
    public partial class ScoreShippingRateInputDraft : IScoreShippingRateInputDraft
    {
        public string Type { get; set; }

        public double Score { get; set; }
        public ScoreShippingRateInputDraft()
        {
            this.Type = "Score";
        }
    }
}
