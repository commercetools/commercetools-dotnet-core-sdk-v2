namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceRemoveStagedChangesAction : IStandalonePriceRemoveStagedChangesAction
    {
        public string Action { get; set; }
        public StandalonePriceRemoveStagedChangesAction()
        {
            this.Action = "removeStagedChanges";
        }
    }
}
