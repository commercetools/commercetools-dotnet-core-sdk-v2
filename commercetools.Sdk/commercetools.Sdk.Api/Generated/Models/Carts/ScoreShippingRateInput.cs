namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class ScoreShippingRateInput : IScoreShippingRateInput
    {
        public string Type { get; set; }

        public double Score { get; set; }
        public ScoreShippingRateInput()
        {
            this.Type = "Score";
        }
    }
}
