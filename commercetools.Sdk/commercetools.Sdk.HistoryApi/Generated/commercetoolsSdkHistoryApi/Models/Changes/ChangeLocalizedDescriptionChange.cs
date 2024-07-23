using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLocalizedDescriptionChange : IChangeLocalizedDescriptionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString PreviousValue { get; set; }

        public ILocalizedString NextValue { get; set; }
        public ChangeLocalizedDescriptionChange()
        {
            this.Type = "ChangeLocalizedDescriptionChange";
        }
    }
}
