namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    public partial class ChangeTargetShippingChangeValue : IChangeTargetShippingChangeValue
    {
        public string Type { get; set; }
        public ChangeTargetShippingChangeValue()
        {
            this.Type = "shipping";
        }
    }
}
