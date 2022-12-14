namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetKeyAction : IStandalonePriceSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public StandalonePriceSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
