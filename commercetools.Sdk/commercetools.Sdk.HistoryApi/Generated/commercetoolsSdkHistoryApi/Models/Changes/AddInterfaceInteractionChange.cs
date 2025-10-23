using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddInterfaceInteractionChange : IAddInterfaceInteractionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFields NextValue { get; set; }
        public AddInterfaceInteractionChange()
        {
            this.Type = "AddInterfaceInteractionChange";
        }
    }
}
