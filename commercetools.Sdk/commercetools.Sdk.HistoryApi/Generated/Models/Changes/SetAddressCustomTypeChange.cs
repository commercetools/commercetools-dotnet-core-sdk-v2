using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAddressCustomTypeChange : ISetAddressCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAddress Address { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetAddressCustomTypeChange()
        {
            this.Type = "SetAddressCustomTypeChange";
        }
    }
}
