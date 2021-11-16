namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetSalutationChange : ISetSalutationChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetSalutationChange()
        {
            this.Type = "SetSalutationChange";
        }
    }
}
