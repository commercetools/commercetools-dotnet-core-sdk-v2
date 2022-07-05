namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ScoreShippingRateInputDraft : IScoreShippingRateInputDraft
    {
        public string Type { get; set; }

        public decimal Score { get; set; }
        public ScoreShippingRateInputDraft()
        {
            this.Type = "Score";
        }
    }
}
