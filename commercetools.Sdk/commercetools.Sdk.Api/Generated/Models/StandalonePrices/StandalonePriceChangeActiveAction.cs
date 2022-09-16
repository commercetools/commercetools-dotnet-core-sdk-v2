namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceChangeActiveAction : IStandalonePriceChangeActiveAction
    {
        public string Action { get; set; }

        public bool Active { get; set; }
        public StandalonePriceChangeActiveAction()
        {
            this.Action = "changeActive";
        }
    }
}
