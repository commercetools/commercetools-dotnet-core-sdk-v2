namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceApplyStagedChangesAction : IStandalonePriceApplyStagedChangesAction
    {
        public string Action { get; set; }
        public StandalonePriceApplyStagedChangesAction()
        {
            this.Action = "applyStagedChanges";
        }
    }
}
