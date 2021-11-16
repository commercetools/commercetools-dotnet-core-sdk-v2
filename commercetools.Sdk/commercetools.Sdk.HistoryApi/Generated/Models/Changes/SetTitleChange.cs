namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetTitleChange : ISetTitleChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetTitleChange()
        {
            this.Type = "SetTitleChange";
        }
    }
}
