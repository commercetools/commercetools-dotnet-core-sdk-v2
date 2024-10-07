

namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ScoreShippingRateInput : IScoreShippingRateInput
    {
        public IShippingRateInputType Type { get; set; }

        public long Score { get; set; }
        public ScoreShippingRateInput()
        {
            this.Type = IShippingRateInputType.FindEnum("Score");
        }
    }
}
