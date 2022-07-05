using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceChangeValueAction : IStandalonePriceChangeValueAction
    {
        public string Action { get; set; }

        public IMoney Value { get; set; }
        public StandalonePriceChangeValueAction()
        {
            this.Action = "changeValue";
        }
    }
}
