namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeSortOrderChange : IChangeSortOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangeSortOrderChange()
        {
            this.Type = "ChangeSortOrderChange";
        }
    }
}
