using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTopLevelUnitChange : IChangeTopLevelUnitChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IKeyReference PreviousValue { get; set; }

        public IKeyReference NextValue { get; set; }
        public ChangeTopLevelUnitChange()
        {
            this.Type = "ChangeTopLevelUnitChange";
        }
    }
}
