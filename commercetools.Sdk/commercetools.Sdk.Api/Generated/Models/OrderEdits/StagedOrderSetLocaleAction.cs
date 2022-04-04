namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetLocaleAction : IStagedOrderSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public StagedOrderSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
