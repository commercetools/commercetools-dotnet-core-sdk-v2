using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTaxModeChange : IChangeTaxModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxMode PreviousValue { get; set; }

        public ITaxMode NextValue { get; set; }
        public ChangeTaxModeChange()
        {
            this.Type = "ChangeTaxModeChange";
        }
    }
}
