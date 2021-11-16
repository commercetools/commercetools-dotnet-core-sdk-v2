using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddInterfaceInteractionChange : IAddInterfaceInteractionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFieldExpandedValue NextValue { get; set; }
        public AddInterfaceInteractionChange()
        {
            this.Type = "AddInterfaceInteractionChange";
        }
    }
}
