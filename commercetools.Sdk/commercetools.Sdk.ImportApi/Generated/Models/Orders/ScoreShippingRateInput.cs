namespace commercetools.ImportApi.Models.Orders
{
    public partial class ScoreShippingRateInput : IScoreShippingRateInput
    {
        public IShippingRateInputType Type { get; set; }

        public double Score { get; set; }
        public ScoreShippingRateInput()
        {
            this.Type = IShippingRateInputType.FindEnum("Score");
        }
    }
}
