namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetRestockableInDaysChange : ISetRestockableInDaysChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }
        public SetRestockableInDaysChange()
        {
            this.Type = "SetRestockableInDaysChange";
        }
    }
}
